using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //variable
    public float speed;

    private void Update() {
        //move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
