using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour
{
    public Text scoreUI;
    public int score = 0;
    public static ScoreKeeper Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        score = 0;  
    }

    void Update() {
        Debug.Log("score increased");
        string playerScore = score.ToString();
        scoreUI.text = $"Score: {playerScore}";
    }

    public void IncreaseScore()
    {
        score += 10;
    }


}
