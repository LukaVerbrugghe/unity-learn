using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProjectileMoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private void Update() {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
