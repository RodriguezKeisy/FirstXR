using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMagneticKey
{
    // Metodo per identificare il tipo di chiave
    void ActivateKey();

    // Metodo che verifica se la chiave è quella giusta per la porta
    bool IsCorrectKey();
}



