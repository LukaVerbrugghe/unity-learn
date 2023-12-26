using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    [SerializeField] private float obstacleSpeed = 30;

    private void Update() {
        transform.Translate(Vector3.left * Time.deltaTime * obstacleSpeed);
    }
}
