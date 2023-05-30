using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text scoreUI;
    public Text gameOverText;
    // Start is called before the first frame update
    public void Setup(string scoreText)
    {
        gameObject.SetActive(true);
        scoreUI.text = scoreText;
        gameOverText.text = gameOverText.text + ", " + PlayerPrefs.GetString("name");;
    }
}
