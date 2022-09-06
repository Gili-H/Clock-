using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands_Controller : MonoBehaviour
{
    
    private float RotationSpeed = 0.1f;

    private void OnMouseDrag()
    {
        //float rotX = Input.GetAxis("Mouse X") * RotationSpeed;
        float rotX = Input.GetAxis("Mouse Y") * RotationSpeed;
        //transform.Rotate(Vector3.up, -rotX);
        transform.RotateAround(Vector3.forward, rotX);
    }
}
