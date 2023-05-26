using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Vector3 SpawnPos;
    public GameObject spawnObject;
    public Transform SpawnPlaceholder;
    private float newSpawnDuration = 1.5f;

    #region Singleton

    public static Spawner Instance;
    
    private void Awake()
    {
        Instance = this;
    }

    #endregion

    private void Start() {
        SpawnPos = SpawnPlaceholder.position;
        //SpawnNewObject();
    }

    void SpawnNewObject()
    {
        Instantiate(spawnObject, SpawnPos, Quaternion.identity);
    }

    public void NewSpawnRequest()
    {
        Invoke("SpawnNewObject", newSpawnDuration);
    }
}
