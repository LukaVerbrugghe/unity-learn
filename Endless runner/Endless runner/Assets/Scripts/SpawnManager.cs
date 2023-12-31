using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {


    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Vector3 spawnPosition;

    private float startTime = 2.0f;
    private float repeatRate = 2;

    private void Start() {
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }

    private void SpawnObstacle() {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}

