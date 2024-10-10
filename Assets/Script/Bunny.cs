using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    public int scoreValue = 1;  // Il valore del punteggio che questo oggetto darà

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se il giocatore ha toccato l'oggetto
        if (other.CompareTag("coins"))
        {
            // Trova il gestore del punteggio e aggiungi il punteggio
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);
            }

            // Distruggi l'oggetto
            Destroy(gameObject);
        }
    }
}