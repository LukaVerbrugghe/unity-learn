using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour {
    private float secondSpeed = 20f;
    private float secondRotationSpeed = 50f;
    private float secondHorizontalInput;
    private float secondVerticalInput;

    // Update is called once per frame
    void () {
        //horizontal and vertical input with input system
        secondHorizontalInput = Input.GetAxis("Horizontal2");
        secondVerticalInput = Input.GetAxis("Vertical2");

        //move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * secondSpeed * secondVerticalInput);

        //rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * secondRotationSpeed * secondHorizontalInput);
    }
}
