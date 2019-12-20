using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 RotationAxis = Vector3.up;
    public float RotationRate = 15.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationAxis, RotationRate * Time.deltaTime);
    }
}
