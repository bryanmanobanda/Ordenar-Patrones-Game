using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoria1Nivel1 : MonoBehaviour
{
    public MoveSystem A;
    public MoveSystem B;
    public MoveSystem C;
    public MoveSystem D;

    public GameObject enemy1;
    void Start()
    {
        Invoke("ShowEnemy", 30f);
        Debug.Log("enemigo en 30s");
    }
    // Update is called once per frame
    void Update()
    {
        
        if(A.next == 1 && B.next == 1&& C.next == 1&& D.next == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("iRON mAN");
        if (collision.gameObject.CompareTag("A"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ShowEnemy()
    {
        enemy1.gameObject.SetActive(true);
        Invoke("OcultarEnemy", 4f);
        Debug.Log("enemigo se va en 4s");
    }
    public void OcultarEnemy()
    {
        enemy1.gameObject.SetActive(false);

    }
}
