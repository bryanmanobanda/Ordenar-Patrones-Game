using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaFinDelJuego : MonoBehaviour
{
    public Button botonReinicio;

    private void Start()
    {
        botonReinicio.onClick.AddListener(ReiniciarNivel);
    }

    private void ReiniciarNivel()
    {
        SceneManager.LoadScene(Score.escenaActual);
    }
}