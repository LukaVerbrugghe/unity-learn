using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variable for restricton
    private float positiveBoundZ = 30;
    private float negativeBoundZ = -6;
    private float BoundX = 25;

    DetectCollisions DetectCollisions = new DetectCollisions();

    private int AantalLevens = 0;

    private void GameOver() {
        Debug.Log("Game over");
    }
    private void Update() {
        //check if the object should be destroyed
        if (transform.position.z > positiveBoundZ || transform.position.x > BoundX || transform.position.x < -BoundX) {
            Destroy(gameObject);
        } else if (transform.position.z < negativeBoundZ) { 
            Destroy(gameObject);
            AantalLevens--;
            if (AantalLevens < 0) {
                GameOver();
            }
        }
    }
}
