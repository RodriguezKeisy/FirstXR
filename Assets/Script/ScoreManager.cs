using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text currentScoreText;  // Riferimento alla UI per mostrare il punteggio attuale
    public TMP_Text topScoresText;     // Riferimento alla UI per mostrare i migliori punteggi

    private int currentScore = 0;  // Punteggio attuale
    private int[] topScores = new int[3];  // Array dei migliori 3 punteggi

    private void Start()
    {
        LoadTopScores();  // Carica i migliori punteggi all'inizio della scena
        UpdateScoreUI();
    }

    // Metodo chiamato quando un oggetto viene raccolto
    public void AddScore(int amount)
    {
        currentScore += amount;  // Aumenta il punteggio attuale
        UpdateScoreUI();
    }

    // Aggiorna la UI del punteggio
    private void UpdateScoreUI()
    {
        currentScoreText.text = "Punteggio attuale: " + currentScore;
        topScoresText.text = $"Migliori punteggi:\n1: {topScores[0]}\n2: {topScores[1]}\n3: {topScores[2]}";
    }

    // Chiama questo metodo alla fine del gioco per salvare il punteggio e aggiornare i migliori punteggi
    public void SaveScore()
    {
        for (int i = 0; i < topScores.Length; i++)
        {
            if (currentScore > topScores[i])
            {
                // Inserisci il punteggio attuale nella classifica e sposta gli altri punteggi
                for (int j = topScores.Length - 1; j > i; j--)
                {
                    topScores[j] = topScores[j - 1];
                }
                topScores[i] = currentScore;
                break;
            }
        }
        SaveTopScores();  // Salva i migliori punteggi
    }

    // Salva i migliori punteggi utilizzando PlayerPrefs
    private void SaveTopScores()
    {
        for (int i = 0; i < topScores.Length; i++)
        {
            PlayerPrefs.SetInt("TopScore" + i, topScores[i]);
        }
        PlayerPrefs.Save();
    }

    // Carica i migliori punteggi salvati
    private void LoadTopScores()
    {
        for (int i = 0; i < topScores.Length; i++)
        {
            topScores[i] = PlayerPrefs.GetInt("TopScore" + i, 0);
        }
    }
}
