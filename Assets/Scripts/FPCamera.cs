using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    public Camera Camara;

    public float horizontalSpeed = 1;
    public float verticalSpeed = 1;

    float h;
    float v;

    
    void Update()
    {

        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        Camara.transform.Rotate(-v, 0, 0);

    }
}
