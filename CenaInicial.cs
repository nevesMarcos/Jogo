using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CenaInicial : MonoBehaviour
{
    private void OnGUI()
    {
        //---------------------------------Textos do jogo -----------------------------------------//
        GUI.Label(new Rect(Screen.width / 2 + 20, (Screen.height / 2) - 60, 500, 500), "Caça Palavras");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 240, 440, 500), "Encontre 4 nomes!");
        //----------------------------Botoes retornar e sair-----------------------------------------//
        if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 6) + 280, 60, 30), "Jogar"))
        {
            SceneManager.LoadScene("Cena1");
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 60, (Screen.height / 6) + 280, 60, 30), "sair"))
        {
            Application.Quit();
        }
    }
    
}
