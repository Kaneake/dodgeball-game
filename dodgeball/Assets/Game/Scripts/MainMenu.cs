using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame () {
        Debug.Log("Exited the game");
        Application.Quit();
    }

    public void OpenMenu () {
        SceneManager.LoadScene("Menu");
    }
}
