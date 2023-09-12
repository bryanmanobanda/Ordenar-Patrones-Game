using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarJuego : MonoBehaviour
{
    public void reiniciarJuego()
    {
        SceneManager.LoadScene("Menu Inicial");
    }
}
