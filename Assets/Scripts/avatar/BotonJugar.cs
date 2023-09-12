using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}
