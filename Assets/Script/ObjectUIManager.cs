using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUIManager : MonoBehaviour
{
    public GameObject uiPanel; // Riferimento al pannello UI da mostrare/nascondere

    // Mostra la UI
    public void ShowUI()
    {
        uiPanel.SetActive(true);
        Debug.Log("UI mostrata.");
    }

    // Nascondi la UI
    public void HideUI()
    {
        uiPanel.SetActive(false);
        Debug.Log("UI nascosta.");
    }
}
