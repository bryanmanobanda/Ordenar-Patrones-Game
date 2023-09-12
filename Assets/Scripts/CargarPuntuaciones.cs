using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CargarPuntuaciones : MonoBehaviour
{
    public Text nombreJugadorUI;
    public Text puntuacionJugadorUI;

    // Nombre del archivo JSON en la carpeta Assets
    public string nombreArchivo = "datosJugador.json";

    void Start()
    {
        CargarNombre();
        CargarPuntuacion();
    }

    void Update()
    {

    }

    void CargarNombre()
    {
        // Obtener la ruta completa del archivo JSON en la carpeta Assets
        string rutaCompleta = Path.Combine(Application.dataPath, nombreArchivo);

        // Verificar si el archivo existe
        if (File.Exists(rutaCompleta))
        {
            // Leer el contenido del archivo
            string json = File.ReadAllText(rutaCompleta);

            // Convertir el JSON a una clase DatosJugador
            GuardarNombre.DatosJugador datos = JsonUtility.FromJson<GuardarNombre.DatosJugador>(json);

            // Mostrar el nombre en la UI
            nombreJugadorUI.text = datos.nombre;
        }
        else
        {
            Debug.LogError("El archivo con el nombre no existe");
        }
    }

    void CargarPuntuacion()
    {
        // Obtener la puntuación acumulada de PlayerPrefs y mostrarla en la UI
        int puntuacion = PlayerPrefs.GetInt("puntosAcumulados2", 0);
        puntuacionJugadorUI.text = "Puntos: " + puntuacion.ToString();
    }
}

