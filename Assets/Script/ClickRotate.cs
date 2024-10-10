using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRotate : MonoBehaviour
{
    bool avvio;
    void Update()
    {
        if(avvio == true)
        {
            transform.Rotate(0, 0, 1);
        }
    }


    public void Rotate()
    {
        avvio = false;
    }


    public void OnDestroy()
    {
        Destroy(gameObject);
    }


}
