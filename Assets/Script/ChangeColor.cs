using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void ColorChangeMagenta()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void ColorChangeCyan()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }
}
