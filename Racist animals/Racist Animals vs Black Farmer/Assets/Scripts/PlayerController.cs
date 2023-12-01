using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    private float horizontalInput;
    private float verticalInput;
    private float speed = 25;
    private int xBound = 10; //restrictions of player movement
    private int yBoundMax = 5;
    private int yBoundMin = 0;
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

        verticalInput = Input.GetAxis("Vertical");
        if(transform.position.y > yBoundMax) {
            transform.position = new Vector3(yBoundMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x < yBoundMin) {
            transform.position = new Vector3(yBoundMin, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);

        //projectile handling
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(prefab, transform.position, prefab.transform.rotation);
        }
    }
}
