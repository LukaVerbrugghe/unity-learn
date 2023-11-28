using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 10;
    private int spawnRangeZ = 20;

    private void Update() {
        //dier spawnen
        if (Input.GetKeyDown(KeyCode.S)) { 
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.RandomRange(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
