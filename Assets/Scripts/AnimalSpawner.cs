using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 20;
    private float spawnPostionZ = 29;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 spawnPostion = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPostionZ);
        Instantiate(animalsPrefabs[animalIndex], spawnPostion, animalsPrefabs[animalIndex].transform.rotation);
    }
}
