using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REgresar : MonoBehaviour
{
    
    public void Regresar()
    {
        SceneManager.LoadScene("Menu Inicial");
    }
}
