using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDistractor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Asigna el componente SpriteRenderer desde el Inspector
    public AudioClip audioClip; // Asigna el audio que deseas reproducir desde el Inspector
    private AudioSource audioSource;
    private float tiempoMinimo = 30f; // 30 segundos
    private float tiempoMaximo = 35f; // 2 minutos

    private void Start()
    {
        // Obtén la referencia al componente AudioSource
        audioSource = GetComponent<AudioSource>();

        // Inicia una corutina para mostrar el sprite después de un tiempo aleatorio
        StartCoroutine(MostrarSpriteDespuesDeTiempoRandom());
    }

    IEnumerator MostrarSpriteDespuesDeTiempoRandom()
    {
        // Espera un tiempo aleatorio entre tiempoMinimo y tiempoMaximo
        float tiempoDeEspera = Random.Range(tiempoMinimo, tiempoMaximo);
        yield return new WaitForSeconds(tiempoDeEspera);

        // Activa el sprite
        spriteRenderer.enabled = true;

        // Reproduce el audio
        if (audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        yield return new WaitForSeconds(10f);
        spriteRenderer.enabled =false;  
    }
}
