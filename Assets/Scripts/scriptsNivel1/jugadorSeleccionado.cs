using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorSeleccionado : MonoBehaviour
{
    public GameObject jugador1;
    public GameObject jugador2;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("jugador")==0)
        {
            jugador1.SetActive(true);

        }else
        {
            jugador2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
