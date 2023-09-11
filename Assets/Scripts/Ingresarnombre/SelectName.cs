using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class SelectName : MonoBehaviour
{
    public InputField inputText;
    public Text textoNombre;
    public Image luz;
    public GameObject botonAceptar;
    
    private void Awake()
    {
        luz.color = Color.red;
    }
    

    private void Update()
    {
        if(textoNombre.text.Length < 4)
        {
            luz.color = Color.red;
            botonAceptar.SetActive(false);
        }
        if (textoNombre.text.Length >= 4)
        {
            luz.color = Color.green;
            botonAceptar.SetActive(true);
        }

    }
    public void aceptar()
    {
        PlayerPrefs.SetString("nombre1", inputText.text);
        // Crear una instancia de la clase DatosJugador y asignar el nombre ingresado
        GuardarNombre.DatosJugador datos = new GuardarNombre.DatosJugador();
        datos.nombre = inputText.text;

        // Convertir los datos a formato JSON
        string json = JsonUtility.ToJson(datos);

        // Obtener la ruta completa del archivo JSON en la carpeta "Assets"
        string rutaCompleta = Path.Combine(Application.dataPath, "datosJugador.json");

        // Escribir el JSON en el archivo
        File.WriteAllText(rutaCompleta, json);
        SceneManager.LoadScene("Avatars");
    }
}
