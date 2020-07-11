using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Kod som jag lånat från internet

    public float rotationSpeed = 10;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }

}
