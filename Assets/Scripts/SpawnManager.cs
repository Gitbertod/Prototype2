using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnposX = 20;
    private float spawnPosZ = 20;
    private float delaySpawn = 1;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",delaySpawn, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randomPos = new Vector3(Random.Range(-spawnposX, spawnposX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], randomPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
