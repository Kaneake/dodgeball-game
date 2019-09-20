using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using static Enemy;


public class Game : MonoBehaviour
{
    public AudioClip bounceSound;
    public AudioClip splatSound;
    public AudioClip boomSound;
    public AudioClip coinSound;
    public AudioClip enemyExplode;
    public AudioClip victorySound;
    public AudioClip danceMusic;
    public AudioClip loseSound;

    public static Game GetInstance()
    {
        return GameObject.FindWithTag("GameController").GetComponent<Game>();
    }

    void Awake()
    {

    }

    void Start()
    {
       
    }

    void Update()
    {

    }

}
