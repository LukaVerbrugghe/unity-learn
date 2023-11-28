using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 10;
    private int spawnRangeZ = 20;
    private float startDelay = 2;
    private float repeatRate = 1.5f;

    private void Start() {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRate);
    }

    private void Update() {
       
    }

    private void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.RandomRange(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
