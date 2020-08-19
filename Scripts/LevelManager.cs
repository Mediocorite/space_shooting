using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("gameover");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
