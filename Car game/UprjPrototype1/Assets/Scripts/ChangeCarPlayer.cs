using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarPlayer : MonoBehaviour
{
    //script public maken zodat dIE KLOTEZOOI EINDELIJK WERKT EN QUINTEN BLIJ wrod
    public PlayerController _PlayerController;
    public SecondPlayerController _SecondPlayerController;

    //een reference naar de speler maken
    public GameObject player1;
    public GameObject player2;

    public MeshFilter filterPlayer1;
    public MeshFilter filterPlayer2;

    public Mesh vehicle1;
    public Mesh vehicle2;
    public Mesh vehicle3;
    public Mesh vehicle4;
    public Mesh vehicle5;

    public float tankSpeed;
    public float busSpeed;
    public float blueCarSpeed;
    public float redCarSpeed;
    public float vanSpeed;

    private void Update()
    {
        //input vragen
        if (Input.GetKeyDown("1"))
        {
            filterPlayer1.mesh = vehicle1;
            _PlayerController.GetComponent<PlayerController>().speed = tankSpeed;
        }
        else if (Input.GetKeyDown("2"))
        {
            filterPlayer1.mesh = vehicle2;
            _PlayerController.GetComponent<PlayerController>().speed = busSpeed;
        }
        else if(Input.GetKeyDown("3")) 
        {
            filterPlayer1.mesh = vehicle3;
            _PlayerController.GetComponent<PlayerController>().speed = blueCarSpeed;
        }
        else if (Input.GetKeyDown("4"))
        {
            filterPlayer1.mesh = vehicle4;
            _PlayerController.GetComponent<PlayerController>().speed = redCarSpeed;
        }
        else if (Input.GetKeyDown("5")) 
        {
            filterPlayer1.mesh = vehicle5;
            _PlayerController.GetComponent<PlayerController>().speed = vanSpeed;
        }
        else if (Input.GetKeyDown("6"))
        {
            filterPlayer2.mesh = vehicle1;
            _SecondPlayerController.GetComponent<SecondPlayerController>().speed = tankSpeed;
        }
        else if (Input.GetKeyDown("7"))
        {
            filterPlayer2.mesh = vehicle2;
            _SecondPlayerController.GetComponent<SecondPlayerController>().speed = busSpeed;
        }
        else if (Input.GetKeyDown("8"))
        {
            filterPlayer2.mesh = vehicle3;
            _SecondPlayerController.GetComponent<SecondPlayerController>().speed = blueCarSpeed;

        } else if (Input.GetKeyDown("9"))
        {
            filterPlayer2.mesh = vehicle4;
            _SecondPlayerController.GetComponent<SecondPlayerController>().speed = redCarSpeed;

        } else if (Input.GetKeyDown("0"))
        {
            filterPlayer2.mesh = vehicle5;
            _SecondPlayerController.GetComponent<SecondPlayerController>().speed = vanSpeed;
        }
    }
}
