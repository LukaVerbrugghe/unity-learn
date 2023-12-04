using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    public int score = 0; 
    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
        score++;
    }
}
