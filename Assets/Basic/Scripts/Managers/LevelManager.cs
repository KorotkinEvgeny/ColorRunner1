using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    public string [] levelNamesArray;


    private int currentLevel = 0;




    public void LoadLevel()
    {
        if (currentLevel != null)
        {
            SceneManager.LoadScene(levelNamesArray[currentLevel]);
        }

    }

    public void StartGameFromBeggining()
    {
        //Application.LoadLevel(levelsArray.);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
