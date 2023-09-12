using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaNivel3 : MonoBehaviour
{
    public MoveSystem A;
    public MoveSystem B;
    public MoveSystem C;
    public MoveSystem D;
    public MoveSystem E;
    public MoveSystem F;

    public GameObject enemy3;
    void Start()
    {
        Invoke("ShowEnemy", 30f);
        Debug.Log("enemigo en 30s");
    }

    void Update()
    {
        if (A.next == 1 && B.next == 1 && C.next == 1 && D.next == 1 && E.next == 1 && F.next == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("A"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ShowEnemy()
    {
        enemy3.gameObject.SetActive(true);
        Invoke("OcultarEnemy", 4f);
        Debug.Log("enemigo se va en 4s");
    }
    public void OcultarEnemy()
    {
        enemy3.gameObject.SetActive(false);

    }
}
