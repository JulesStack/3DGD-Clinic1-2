using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour {

    public GameObject ObjectToSpawn;
    public Transform SpawnLocation;

    void Start()
    {
        GenerateObject();

    }

    public void GenerateObject()
    {
        Instantiate(ObjectToSpawn, SpawnLocation.position, transform.rotation);
    }
}
