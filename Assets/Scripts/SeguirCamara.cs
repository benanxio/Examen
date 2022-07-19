using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    public Transform objetivo;
    void Update()
    {
        transform.LookAt(objetivo);
        transform.Rotate(Vector3.up * 180);
    }
}
