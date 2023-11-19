using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex],new Vector3(0,0,20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}