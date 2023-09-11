using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDistractor : MonoBehaviour
{
    private GameObject elemento; // El objeto que deseas mostrar y ocultar

    void Start()
    {
        // Encuentra el objeto en la escena por su nombre o etiqueta
        elemento = GameObject.Find("distractorNivel1-removebg-preview"); // Cambia "NombreDelElemento" al nombre real de tu elemento

        // Asegúrate de que el objeto esté desactivado al inicio
        elemento.SetActive(false);

        // Llama a una función para mostrar el elemento después de 5 segundos
        Invoke("MostrarElemento", 5f);
    }

    void MostrarElemento()
    {
        // Activa el elemento para que sea visible
        elemento.SetActive(true);

        // Llama a una función para ocultar el elemento después de 5 segundos adicionales
        Invoke("OcultarElemento", 5f);
    }

    void OcultarElemento()
    {
        // Desactiva el elemento para que sea invisible
        elemento.SetActive(false);
    }
}
