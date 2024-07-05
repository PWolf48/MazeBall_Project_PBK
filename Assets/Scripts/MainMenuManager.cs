using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("MazeGame");
    }
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame(){
        Application.Quit();
    }
}
