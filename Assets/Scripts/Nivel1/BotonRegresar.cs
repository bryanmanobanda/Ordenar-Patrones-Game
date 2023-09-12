using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonRegresar : MonoBehaviour
{
    public void Regresar()
    {
        SceneManager.LoadScene("Avatars");
    }
}
