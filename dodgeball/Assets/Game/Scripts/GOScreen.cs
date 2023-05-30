using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOScreen : MonoBehaviour
{
    public GameOver GameOver;
    private string scoreText;
    public Text scoreDisplay;
    public void GameOverFunc()
    {  
        scoreText = scoreDisplay.text;
        GameOver.Setup(scoreText);
    }

    private void OnCollisionEnter(Collision other) {
       
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("game over");
            GameOverFunc();
        }
    }
}
