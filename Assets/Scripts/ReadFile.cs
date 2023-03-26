using UnityEngine;
using Task = System.Threading.Tasks.Task;

public class ReadFile : MonoBehaviour
{
    private const string Path = @"C:\Users\Admin\Documents\Lessons\Dz14\Assets\Text.txt";

    private static async Task ReadTextFromFile()
    {
        var text = await System.IO.File.ReadAllTextAsync(Path);
        Debug.Log(text);
    }

    private async void Start()
    {
        await ReadTextFromFile();
    }
}