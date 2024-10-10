using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectResizer : MonoBehaviour
{
    public GameObject objectToResize;  // Riferimento all'oggetto da ridimensionare
    public Slider sizeSlider;  // Riferimento allo slider

    private void Start()
    {
        sizeSlider.onValueChanged.AddListener(OnSliderValueChanged);  // Collega il valore dello slider al metodo
    }

    // Metodo chiamato quando lo slider cambia valore
    public void OnSliderValueChanged(float value)
    {
        // Ridimensiona l'oggetto in base al valore dello slider
        objectToResize.transform.localScale = new Vector3(value, value, value);
    }
}
