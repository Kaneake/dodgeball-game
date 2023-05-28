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
            //Destroy(other.gameObject);
            Debug.Log("enemy hit");
        }
    } 

    // private void OnDestroy() {
    //     EnemySpawner.Instance.SpawnNewObject();
    // }
}
