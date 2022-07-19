using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    float ejeVertical,rotY;
    float angulo = 45;

    void Update()
    {
        ejeVertical = Input.GetAxis("Mouse Y");
        transform.Rotate(-ejeVertical * angulo * Time.deltaTime,0,0);
    }
}
