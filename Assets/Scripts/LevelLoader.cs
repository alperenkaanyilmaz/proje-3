using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator LoadLevelAsync(string levelName)
    {
       
        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);
        while (!op.isDone) yield return null;
    }
}
