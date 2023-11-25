using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    private float horizontalInput;
    private float speed = 25;
    private int xBound = 10; //restrictions of player movement
    public GameObject prefab; //to instantiate the projectile

    private void Update() {
        //player movement
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x < -xBound) {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound) { 
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z) ; 
        }
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        //projectile handling
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(prefab, transform.position, prefab.transform.rotation);
        }
    }
}
