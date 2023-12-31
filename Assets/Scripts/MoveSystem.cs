using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MoveSystem : MonoBehaviour
{
    public int next=0;
    public int acumulados;
    public GameObject correctForm;
    public Text puntos;
    private bool moving;
    private bool finish;
    public bool destroyObject;
    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = this.transform.localPosition;
        acumulados += PlayerPrefs.GetInt("puntosAcumulados");
        PlayerPrefs.SetInt("puntosAcumulados2", acumulados);
    }

    void Update()
    {
        if (finish==false) {    
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            moving = true;
        }
    }
    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 5.0f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 5.0f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
            Score.points = Score.points + 10;
            puntos.text = Score.points.ToString();
            //Aqui hizo liz 
            next++;
            //Debug.Log(next);
            
            PlayerPrefs.SetInt("puntosAcumulados", Score.points);
            
            Debug.Log(PlayerPrefs.GetInt("puntosAcumulados"));
            Debug.Log(PlayerPrefs.GetInt("puntosAcumulados2"));
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            Score.points = Score.points -5;
            puntos.text = Score.points.ToString();
            if (destroyObject)
            {
                Destroy(gameObject, 0.3f);
            }
        }
     }
}
