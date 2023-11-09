using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variable for offset camera
    private Vector3 offset = new Vector3(0, 5, -10);
    public GameObject player;


    // Update is called once per frame
    void LateUpdate()
    {
        //placing camera
        transform.position = player.transform.position + offset;
    }
}
