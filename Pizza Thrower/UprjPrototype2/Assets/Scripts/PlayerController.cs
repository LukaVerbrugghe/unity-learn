using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerHorizontal;
    public float speed = 25.0f;

    void Update()
    {
        playerHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * playerHorizontal * Time.deltaTime * speed);
    }
}
