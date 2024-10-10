using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public PaintBrush paintBrush;  // Riferimento al pennello

    public void SetColorRed()
    {
        paintBrush.SetBrushColor(Color.red);
    }

    public void SetColorGreen()
    {
        paintBrush.SetBrushColor(Color.green);
    }

    public void SetColorBlue()
    {
        paintBrush.SetBrushColor(Color.blue);
    }
}
