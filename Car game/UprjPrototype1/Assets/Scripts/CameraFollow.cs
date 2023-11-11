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
        if(Input.GetKeyDown("f"))
        {
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
    }
}
