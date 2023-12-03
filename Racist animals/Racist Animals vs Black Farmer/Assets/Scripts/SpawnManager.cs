using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefabs;
    private int spawnRangeXFront = 10;
    private int spawnRangeZFront = 20;
    private int spawnRangeXSide = 20;
    private int spawnRangeZSideMin = 0;
    private int spawnRangeZSideMax = 12;
    private float startDelay = 2;
    private float repeatRate = 1.5f;

    private void Start() {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRate);
    }

    private void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeXFront, spawnRangeXFront), 0, spawnRangeZFront);
        Vector3 spawnPosLeft = new Vector3(-spawnRangeXSide, 0, Random.Range(spawnRangeZSideMin, spawnRangeZSideMax));
        Vector3 spawnPosRight = new Vector3(spawnRangeXSide, 0, Random.Range(spawnRangeZSideMin, spawnRangeZSideMax));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosLeft, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0,-90,0));
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0, 90, 0));
    }
}
