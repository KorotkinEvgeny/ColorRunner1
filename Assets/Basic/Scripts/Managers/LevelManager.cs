using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    private const string levelSelectScene = "LevelSelect";

    public string [] levelNamesArray;

    private static LevelManager instance;

    private int currentLevel = 0;

    void Awake()
    {
        if (!instance)
            instance = this;
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadLevel(int sceneInArray)
    {
        SceneManager.LoadScene(levelNamesArray[sceneInArray]);
    }

    public void LoadSelectMenu()
    {
        SceneManager.LoadScene(levelSelectScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
