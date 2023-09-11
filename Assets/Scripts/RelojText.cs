using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reloj : MonoBehaviour
{
    public float tiempoInicial = 60.0f; 
    private float tiempoRestante;

    public Text textoTiempo;
    public string escenaA;
    public GameObject distractornivel1;

    void Start()
    {
        Score.escenaActual = escenaA;
        tiempoRestante = tiempoInicial;
        ActualizarTextoTiempo();

    }

    void Update()
    {
        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= 0)
        {
            SceneManager.LoadScene("NivelFallido");
        }

        ActualizarTextoTiempo();
    }

    void ActualizarTextoTiempo()
    {
        if (textoTiempo != null)
        {
            int minutos = Mathf.FloorToInt(tiempoRestante / 60);
            int segundos = Mathf.FloorToInt(tiempoRestante % 60);
            textoTiempo.text = "Tiempo: " + minutos.ToString("00") + ":" + segundos.ToString("00");
        }

    }
}