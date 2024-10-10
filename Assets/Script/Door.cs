using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    public GameObject door;  // Riferimento alla porta
    public Renderer readerRenderer;  // Riferimento al lettore della tessera
    public Color defaultColor = Color.red;  // Colore del lettore senza tessera
    public Color activeColor = Color.green;  // Colore del lettore con la tessera corretta
    public float openSpeed = 2f;  // Velocità di apertura della porta

    private bool doorOpened = false;

    private void Start()
    {
        // Imposta il lettore al colore predefinito
        readerRenderer.material.color = defaultColor;

    }

    // Metodo chiamato quando una tessera passa sopra il lettore
    private void OnTriggerEnter(Collider other)
    {
        IMagneticKey key = other.GetComponent<IMagneticKey>();  // Controlla se l'oggetto ha una chiave
        if (key != null)
        {
            key.ActivateKey();

            // Se la chiave è corretta, cambia il colore del lettore e apri la porta
            if (key.IsCorrectKey() && !doorOpened)
            {
                readerRenderer.material.color = activeColor;  // Cambia il lettore in verde
                OpenDoor();
            }
        }
    }

    // Metodo per aprire la porta
    private void OpenDoor()
    {
        Debug.Log("Porta aperta!");
        doorOpened = true;
        StartCoroutine(OpenDoorRoutine());
    }

    private IEnumerator OpenDoorRoutine()
    {
        // Logica per aprire la porta
        Vector3 openPosition = door.transform.position + Vector3.up * 3f;  // Sposta la porta in alto
        while (Vector3.Distance(door.transform.position, openPosition) > 0.1f)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, openPosition, Time.deltaTime * openSpeed);
            yield return null;
        }
    }
}
