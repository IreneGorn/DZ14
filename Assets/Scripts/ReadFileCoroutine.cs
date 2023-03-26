using System.Collections;
using UnityEngine;

public class ReadFileCoroutine : MonoBehaviour
{
    private const string Path = @"C:\Users\Admin\Documents\Lessons\Dz14\Assets\Text.txt";
    private void Start()
    {
        StartCoroutine(ReadTextFromFileCoroutine());
    }

    IEnumerator ReadTextFromFileCoroutine()
    {
        var text = System.IO.File.ReadAllText(Path);
        yield return null;
        Debug.Log(text);
    }
}