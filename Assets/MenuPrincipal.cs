using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MostrarTablaPuntuaciones()
    {
        SceneManager.LoadScene("NombreDeLaEscenaDeTablaDePuntuaciones");
    }
    public void Salir()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
