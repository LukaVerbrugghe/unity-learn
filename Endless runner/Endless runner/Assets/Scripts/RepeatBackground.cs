using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour {

    private Vector3 startPos;
    private float repeatRate;

    private void Start() {
        startPos = transform.position;
        repeatRate = GetComponent<BoxCollider>().size.x / 2;
    }

    private void Update() {
        if (transform.position.x < startPos.x - repeatRate)
        {
            transform.position = startPos;
        }
    }
}
