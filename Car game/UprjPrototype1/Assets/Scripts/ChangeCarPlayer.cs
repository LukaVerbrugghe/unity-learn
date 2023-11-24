using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarPlayer : MonoBehaviour
{
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

    private void Update()
    {
        //input vragen
        if (Input.GetKeyDown("1"))
        {
            filterPlayer1.mesh = vehicle1;
        }
        else if (Input.GetKeyDown("2"))
        {
            filterPlayer1.mesh = vehicle2;
        }
        else if(Input.GetKeyDown("3")) 
        {
            filterPlayer1.mesh = vehicle3;
        }
        else if (Input.GetKeyDown("4"))
        {
            filterPlayer1.mesh = vehicle4;
        }
        else if (Input.GetKeyDown("5")) 
        {
            filterPlayer1.mesh = vehicle5;
        }
        else if (Input.GetKeyDown("6"))
        {
            filterPlayer2.mesh = vehicle1;
        }
        else if (Input.GetKeyDown("7"))
        {
            filterPlayer2.mesh = vehicle2;
        }
        else if (Input.GetKeyDown("8"))
        {
            filterPlayer2.mesh = vehicle3;
        }
        else if (Input.GetKeyDown("9"))
        {
            filterPlayer2.mesh = vehicle4;
        }
        else if (Input.GetKeyDown("0"))
        {
            filterPlayer2.mesh = vehicle5;
        }
    }
}
