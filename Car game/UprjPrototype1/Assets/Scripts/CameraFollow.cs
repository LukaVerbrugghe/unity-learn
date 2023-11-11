using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variable for offset camera
    private Vector3 offsetBehind = new Vector3(0, 5, -10);
    private Vector3 offsetUp = new Vector3(0, 7.5f, -10);
    private Vector3 offsetDriverSeat = new Vector3(0, 2.5f, 2.5f);
    private Vector3 offset;
    public GameObject player;

    private void Start() {
        offset = offsetBehind;

    }

    void Update() {
        //does the camera needs to move?
        if(Input.GetKeyDown("f"))
        {
         //swithch camera offset
            if (offset == offsetBehind) {
                offset = offsetUp;
            }
            else if (offset == offsetUp) {
                offset = offsetDriverSeat;
            }
            else { offset = offsetBehind;}
        }
    }

    void LateUpdate()
    {
        //placing camera
        transform.position = player.transform.position + offset;
        if (offset == offsetDriverSeat) {
            transform.rotation = player.transform.rotation;
        } else {
            transform.Rotate(0,0,0); 
        }
    }
}
