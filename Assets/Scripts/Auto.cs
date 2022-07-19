using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] float velNormal;
    [SerializeField] float velAceleracion;
    [SerializeField] float velRot;
    [SerializeField] float velodidadGiro;
    void Start()
    {
        velocidad = velNormal;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(0,-velRot * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0,velRot * Time.deltaTime,0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidad * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocidad = velAceleracion;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidad = velNormal;
        }
    }
}
