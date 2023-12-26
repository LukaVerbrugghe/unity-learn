using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public float jumpForce;
    private Rigidbody playerRb;
    public float gravityModifier;
    public bool isJumping;

    private void Start() {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        isJumping = false;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        isJumping = false;
    }
}
