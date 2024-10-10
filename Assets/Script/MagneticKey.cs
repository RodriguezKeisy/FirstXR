using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MagneticKey : MonoBehaviour, IMagneticKey
{
    public bool correctKey;  // Definisce se questa è la chiave giusta per aprire la porta

    // Metodo che si attiva quando la chiave viene usata
    public void ActivateKey()
    {
        Debug.Log("Tessera magnetica usata.");
    }

    // Verifica se la chiave è corretta
    public bool IsCorrectKey()
    {
        return correctKey;
    }
}


