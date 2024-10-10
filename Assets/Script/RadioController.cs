using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    public AudioSource audioSource;  // Riferimento al componente AudioSource
    private bool isPlaying = false;  // Stato della musica (se è in riproduzione o meno)

    // Metodo che viene chiamato quando si preme il pulsante (o il joystick)
    public void ToggleRadio()
    {
        if (isPlaying)
        {
            // Se la musica è in riproduzione, fermala
            audioSource.Stop();
            isPlaying = false;
            Debug.Log("Musica spenta.");
        }
        else
        {
            // Se la musica non è in riproduzione, avviala
            audioSource.Play();
            isPlaying = true;
            Debug.Log("Musica accesa.");
        }
    }
}
