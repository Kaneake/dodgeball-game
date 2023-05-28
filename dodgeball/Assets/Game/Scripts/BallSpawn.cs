using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    private Vector3 SpawnPos;
    public GameObject spawnObject;
    public Transform SpawnPlaceholder;

    #region Singleton

    public static BallSpawn Instance;
    
    private void Awake()
    {
        Instance = this;
    }

    #endregion

    private void Start() {
        SpawnPos = SpawnPlaceholder.position;
    }

    void SpawnNewObject()
    {

        Instantiate(spawnObject, SpawnPos, Quaternion.identity);
    }

    public void NewSpawnRequest()
    {
        Invoke("SpawnNewObject", 0.5f);
    }
}
