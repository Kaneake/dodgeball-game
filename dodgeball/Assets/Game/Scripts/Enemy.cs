using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    //EnemyCollisionHandler
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject, 0.6f);
            Debug.Log("enemy hit");
        }
    } 
    public void OnDestroy() {
        ScoreKeeper.Instance.IncreaseScore();
    }
}
