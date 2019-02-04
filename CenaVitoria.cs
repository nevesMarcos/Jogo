using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CenaVitoria : MonoBehaviour
{
    public static float contagem = 0.0f;
    public static float menorTempo = 0.0f;
    void OnGUI()
    {
        //---------------------------------Textos do jogo---------------------------------------------//
        GUI.Label(new Rect(Screen.width / 2 + 20, (Screen.height / 6) - 10, 500, 500), "Caça Palavras");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 10, 500, 500), "Tempo: " + Math.Round(SalverJogo.cronometro) + " Segundos");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 270, 500, 500), "Tempo recorde: " + Math.Round(SalverJogo.tempo) + " s");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 300, 500, 500), "Encontre 4 nomes!");
        //----------------------------Primeira linha de botoes-----------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 50, 30, 30), "L");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 50, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 50, 30, 30), "K");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 50, 30, 30), "i");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 50, 30, 30), "A");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 50, 30, 30), "W");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 50, 30, 30), "i");
        //----------------------------Segunda linha de botoes------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 80, 30, 30), "s");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 80, 30, 30), "T");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 80, 30, 30), "x");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 80, 30, 30), "K");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 80, 30, 30), "L");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 80, 30, 30), "s");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 80, 30, 30), "B");
        //----------------------------Terceira linha de botoes------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 110, 30, 30), "T");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 110, 30, 30), "H");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 110, 30, 30), "L");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 110, 30, 30), "A");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 110, 30, 30), "A");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 110, 30, 30), "T");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 110, 30, 30), "F");
        //----------------------------Quarta linha de botoes------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 140, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 140, 30, 30), "U");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 140, 30, 30), "P");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 140, 30, 30), "Q");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 140, 30, 30), "P");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 140, 30, 30), "W");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 140, 30, 30), "E");
        //----------------------------Quinta linha de botoes------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 170, 30, 30), "H");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 170, 30, 30), "L");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 170, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 170, 30, 30), "L");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 170, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 170, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 170, 30, 30), "i");
        //----------------------------Sexta linha de botoes------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 200, 30, 30), "P");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 200, 30, 30), "Y");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 200, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 200, 30, 30), "Q");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 200, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 200, 30, 30), "U");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 200, 30, 30), "O");
        //----------------------------Ultima linha de botoes-----------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 230, 30, 30), "Q");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 230, 30, 30), "U");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 230, 30, 30), "F");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 230, 30, 30), "U");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 230, 30, 30), "S");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 230, 30, 30), "C");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 230, 30, 30), "A");
        //----------------------------Botoes retornar e sair-----------------------------------------//
        if (GUI.Button(new Rect((Screen.width / 2) , (Screen.height / 6) + 340, 60, 30), "retornar"))
        {
            Sensores.contar = true;
            SceneManager.LoadScene("Cena1");
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 60, (Screen.height / 6) + 340, 60, 30), "sair"))
        {
            Application.Quit();
        }
    }
}
