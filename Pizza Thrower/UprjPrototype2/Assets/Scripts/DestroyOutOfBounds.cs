using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBoundsZ = 30.0f;
    private float lowerBoundsZ = -10.0f;

    private void Update() {
        if (transform.position.z > upperBoundsZ) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBoundsZ) {
            Destroy(gameObject);
        }
    }
}
