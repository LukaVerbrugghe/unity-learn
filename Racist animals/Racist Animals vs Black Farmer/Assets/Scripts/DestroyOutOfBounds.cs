using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variable for restricton
    private float positiveBound = 30;
    private float negativeBound = -6;

    private void Update() {
        //check if the object should be destroyed
        if (transform.position.z > positiveBound) {
            Destroy(gameObject);
        } else if (transform.position.z < negativeBound) { 
            Destroy(gameObject);
            Debug.Log("Game over");
        }
    }
}
