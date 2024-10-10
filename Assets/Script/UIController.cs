using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject drawer;  // Riferimento al cassetto
    public GameObject slidingDoor;  // Riferimento alla porta scorrevole
    public GameObject chest;  // Riferimento al baule

    private bool drawerOpened = false;
    private bool doorOpened = false;
    private bool chestOpened = false;

    // Metodo per aprire il cassetto
    public void ToggleDrawer()
    {
        if (!drawerOpened)
        {
            drawer.transform.position += Vector3.forward * 0.5f;  // Sposta il cassetto in avanti
            drawerOpened = true;
        }
        else
        {
            drawer.transform.position -= Vector3.forward * 0.2f;  // Chiude il cassetto
            drawerOpened = false;
        }
    }

    // Metodo per aprire la porta scorrevole
    public void ToggleSlidingDoor()
    {
        if (!doorOpened)
        {
            slidingDoor.transform.position += Vector3.fwd * 2f;  // Sposta la porta
            doorOpened = true;
        }
        else
        {
            slidingDoor.transform.position -= Vector3.fwd * 2f;  // Chiude la porta
            doorOpened = false;
        }
    }

    // Metodo per aprire il baule
    public void ToggleChest()
    {
        if (!chestOpened)
        {
            chest.transform.position += Vector3.down * 0.2f;  // Sposta il coperchio del baule
            chestOpened = true;
        }
        else
        {
            chest.transform.position -= Vector3.down * 0.2f;  // Chiude il baule
            chestOpened = false;
        }
    }
}

