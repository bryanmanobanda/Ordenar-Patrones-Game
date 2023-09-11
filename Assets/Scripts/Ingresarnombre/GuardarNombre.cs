using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GuardarNombre : MonoBehaviour
{
    // Define una clase para estructurar los datos a guardar en el JSON
    [System.Serializable]
    public class DatosJugador
    {
        public string nombre;
    }

    // Nombre del archivo JSON en la carpeta Assets
    public string nombreArchivo = "datosJugador.json";

    public void GuardarNombreEnJSON(string nombre)
    {
        // Crear una instancia de la clase DatosJugador y asignar el nombre ingresado
        DatosJugador datos = new DatosJugador();
        datos.nombre = nombre;

        // Convertir los datos a formato JSON
        string json = JsonUtility.ToJson(datos);

        // Obtener la ruta completa del archivo JSON en la carpeta Assets
        string rutaCompleta = Path.Combine(Application.dataPath, nombreArchivo);

        // Escribir el JSON en el archivo
        File.WriteAllText(rutaCompleta, json);

        Debug.Log("Nombre guardado en " + nombreArchivo);
    }
}
