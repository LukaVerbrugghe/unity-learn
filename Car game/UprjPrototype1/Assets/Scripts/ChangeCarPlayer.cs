using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarPlayer : MonoBehaviour
{
    //script public maken zodat dIE KLOTEZOOI EINDELIJK WERKT EN QUINTEN BLIJ wrod
    public PlayerController _PlayerController;
    public SecondPlayerController _SecondPlayerController;

    public MeshFilter filterPlayer1;
    public MeshFilter filterPlayer2;

    [SerializeField] private float[] vehicleSpeed;

    [SerializeField] private float[] vehicleMass;

    [SerializeField] private int currentCarIndexPlayer1;
    private int currentCarIndexPlayer2;

    void ChangePropertiesPlayer1() {
        _PlayerController.GetComponent<PlayerController>().speed = vehicleSpeed[currentCarIndexPlayer1];
        _PlayerController.GetComponent<PlayerController>().mass = vehicleMass[currentCarIndexPlayer1];
    }

    void ChangePropertiesPlayer2() {
        _SecondPlayerController.GetComponent<SecondPlayerController>().speed = vehicleSpeed[currentCarIndexPlayer2];
        _SecondPlayerController.GetComponent<SecondPlayerController>().mass = vehicleMass[currentCarIndexPlayer2];
    }

    private void Start() {
        currentCarIndexPlayer1 = 4;
        currentCarIndexPlayer2 = 3;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            if (currentCarIndexPlayer1 < 4) {
                ChangePropertiesPlayer1();
                currentCarIndexPlayer1++;
            }
            else {
                currentCarIndexPlayer1 = 0;
                ChangePropertiesPlayer1();
            }
        }
        if (Input.GetKeyDown(KeyCode.RightShift)) {
            if (currentCarIndexPlayer2 < 4) {
                ChangePropertiesPlayer2();
                currentCarIndexPlayer2++;
            }
            else {
                currentCarIndexPlayer2 = 0;
            }
        }
    }
}
