using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosAcumulados : MonoBehaviour
{
    public Text totalPuntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalPuntos.text = PlayerPrefs.GetInt("puntosAcumulados2").ToString();
    }
}
