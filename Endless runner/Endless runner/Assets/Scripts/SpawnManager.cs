using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {


    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Vector3 spawnPosition;

    private void Start() {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}

