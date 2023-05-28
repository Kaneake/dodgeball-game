using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    private float spawnTimeInterval = Random.Range(3f, 6f);
    private Vector3 SpawnPos;
    public GameObject spawnObject;
    public Transform SpawnPlaceholder;

    #region Singleton

    public static EnemySpawner Instance;
    
    private void Awake()
    {
        Instance = this;
    }

    #endregion

    private void Start(){
        SpawnPos = SpawnPlaceholder.position;
        InvokeSpawning();
        
    }
    public void SpawnNewObject()
    {
        Debug.Log("enemy spawned");
        Instantiate(spawnObject, SpawnPos, Quaternion.identity);
    }

    public void InvokeSpawning(){
        InvokeRepeating("SpawnNewObject", 1f, Random.Range(3f, 6f));
    }

    // IEnumerator EnemySpawnLoop()
    // {
    //     while (true)
    //     {
    //         Instantiate(enemyPrefab, SpawnPos, Quaternion.identity);
    //         yield return new WaitForSeconds(spawnTimeInterval);
    //     }
    // }
      
}
