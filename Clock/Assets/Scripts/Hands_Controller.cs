using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands_Controller : MonoBehaviour
{
    
    private float RotationSpeed = 0.2f;

    [SerializeField]
    private GameObject tzir;

    [SerializeField]
    private float angle;
    public float Angle
    {
        get { return angle; }
        set { angle = value; }
    }

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse Y") * RotationSpeed;
        tzir.transform.RotateAround(Vector3.forward, rotX);

        angle = gameObject.transform.rotation.eulerAngles.z;
    }
}
