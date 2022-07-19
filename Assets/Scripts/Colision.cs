using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    // Handler para el inicio de la colision por medio del trigger
    void OnTriggerEnter(Collider objetoCol)
    {
        SceneManager.LoadScene("Final");
    }
}

