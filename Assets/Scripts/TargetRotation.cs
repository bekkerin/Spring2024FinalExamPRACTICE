using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotation : MonoBehaviour
{
    public float rotationSpeed = 45f; // degrees per second



    // Update is called once per frame
    void Update()
    {
        // rotate around the vertical axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        // rotate around the horizontal axis
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
