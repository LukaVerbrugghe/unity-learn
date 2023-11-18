using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerHorizontal;
    public float speed = 25.0f;
    private float xBorder = 11.0f;

    void Update()
    {
        if (transform.position.x < -xBorder) {
            transform.position = new Vector3(-xBorder,transform.position.y,transform.position.z);
        }
        if (transform.position.x > xBorder) {
            transform.position = new Vector3(xBorder, transform.position.y,transform.position.z);
        }
        playerHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * playerHorizontal * Time.deltaTime * speed);
    }
}
