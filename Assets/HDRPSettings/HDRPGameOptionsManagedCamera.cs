using GameOptionsUtility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

[RequireComponent(typeof(HDAdditionalCameraData))]
public class HDRPGameOptionsManagedCamera : MonoBehaviour
{
    private void OnEnable()
    {
        HDRPCameraOption.AddCamera(GetComponent<HDAdditionalCameraData>());
    }

    private void OnDisable()
    {
        HDRPCameraOption.RemoveCamera(GetComponent<HDAdditionalCameraData>());
    }
}
