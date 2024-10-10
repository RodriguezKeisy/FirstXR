using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PaintBrush : MonoBehaviour
{
    public Color brushColor = Color.white;  // Colore attuale del pennello
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PaintableObject"))
        {
            Renderer objectRenderer = other.GetComponent<Renderer>();
            if (objectRenderer != null)
            {
                objectRenderer.material.color = brushColor;  // Cambia il colore dell'oggetto
                
            }
        }
    }

    public void SetBrushColor(Color newColor)
    {
        brushColor = newColor;  // Cambia il colore del pennello
    }
}
