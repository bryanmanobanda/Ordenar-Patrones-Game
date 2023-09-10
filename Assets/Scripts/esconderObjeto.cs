using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class esconderObjeto : MonoBehaviour
{
    public float tiempoEspera = 5.0f;
    private float tiempoTranscurrido = 0.0f;

    public Text textoContador;

    private int contador = 3;
    private bool contadorActivo = false;

    void Start()
    {
        if (textoContador != null)
        {
            textoContador.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= tiempoEspera)
        {
            gameObject.SetActive(false);

            if (textoContador != null)
            {
                textoContador.gameObject.SetActive(false);
            }
        }
        else if (tiempoEspera - tiempoTranscurrido <= contador && !contadorActivo)
        {
            contadorActivo = true;

            if (textoContador != null)
            {
                textoContador.text = "El patrón desaparecerá en " + contador.ToString();
                textoContador.gameObject.SetActive(true);
                contador--;
            }
        }
        if (contadorActivo && tiempoEspera - tiempoTranscurrido <= contador - 1)
        {
            contadorActivo = false;

            if (textoContador != null)
            {
                textoContador.gameObject.SetActive(false);
            }
        }
    }
}
