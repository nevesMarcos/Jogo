using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MotorGame : MonoBehaviour
{
    // Cria as variaveis, nome e suas posicoes (linha x coluna)
    //------LOKI-----//
    public static string corLoki1x1;
    public static string corLoki1x2;
    public static string corLoki1x3;
    public static string corLoki1x4;
    //------HULK-----//
    public static string corHulk5x1;
    public static string corHulk4x2;
    public static string corHulk3x3;
    public static string corHulk2x4;
    //-----OPALA-----//
    public static string corOpala5x5;
    public static string corOpala4x5;
    public static string corOpala3x5;
    public static string corOpala2x5;
    public static string corOpala1x5;
    //-----FUSCA-----//
    public static string corFusca7x3;
    public static string corFusca7x4;
    public static string corFusca7x5;
    public static string corFusca7x6;
    public static string corFusca7x7;
    //-----Feio-----//
    public static string corFeio3x7;
    public static string corFeio4x7;
    public static string corFeio5x7;
    public static string corFeio6x7;
    //----REINICIA OS VALORES-----//

    // Update is called once per frame
    void Update()
    {
    }
    void OnGUI()
    {
        //
        //---------------------------------------Textos do jogo----------------------------------------------------//
        GUI.Label(new Rect(Screen.width / 2 + 20, (Screen.height / 6) - 10, 500, 500), "Caça Palavras");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 10, 500, 500), "Tempo: " + Math.Round(SalverJogo.cronometro) + " Segundos");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 270, 500, 500), "Tempo recorde: " + Math.Round(SalverJogo.tempo) + " s");
        GUI.Label(new Rect(Screen.width / 2, (Screen.height / 6) + 300, 500, 500), "Encontre 4 nomes!");
        //----------------------------------Primeira linha de botoes-------------------------------------------------//
                                           //-------v LOKI v-------//
        if (corLoki1x1 == "amarelo") {
            GUI.color = Color.yellow;
        }
        if (GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 50, 30, 30), "L"))
        {
            corLoki1x1 = "amarelo";
        }
        GUI.color = Color.white;

        if (corLoki1x2 == "amarelo" && corLoki1x1 == "amarelo")
        {
            GUI.color = Color.yellow;
        }
  
        if (GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 50, 30, 30), "O"))
        {
            corLoki1x2 = "amarelo";
        }
        GUI.color = Color.white;

        if (corLoki1x3 == "amarelo" && corLoki1x2 == "amarelo" && corLoki1x1 == "amarelo")
        {
            GUI.color = Color.yellow;
        }
        if(GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 50, 30, 30), "K"))
        {
            corLoki1x3 = "amarelo";
        }
        GUI.color = Color.white;

        if (corLoki1x4 == "amarelo" && corLoki1x3 == "amarelo" && corLoki1x2 == "amarelo" && corLoki1x1 == "amarelo")
        {
            GUI.color = Color.yellow;
        }
        if(GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 50, 30, 30), "i"))
        {
            corLoki1x4 = "amarelo";
        }
        GUI.color = Color.white;
                                                //--------^ LOKI ^-------//
                                               //--------v OPALA v-------//
        if (corOpala1x5 == "azul")
        {
            GUI.color = Color.blue;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 50, 30, 30), "A"))
        {
            corOpala1x5 = "azul";
        }
        GUI.color = Color.white;
                                               //--------^ OPALA  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 50, 30, 30), "W");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 50, 30, 30), "i");
        //----------------------------------Segunda linha de botoe-------------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 80, 30, 30), "s");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 80, 30, 30), "T");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 80, 30, 30), "x");
                                               //--------v HULK v-------//
        if (corHulk2x4 == "verde" && corHulk3x3 == "verde" && corHulk4x2 == "verde" && corHulk5x1 == "verde")
        {
            GUI.color = Color.green;
        }
        if(GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 80, 30, 30), "K"))
        {
            corHulk2x4 = "verde";
        }
        GUI.color = Color.white;
                                                //--------^ HULK ^-------//
                                               //--------v OPALA v-------//
        if (corOpala2x5 == "azul" && corOpala3x5 == "azul" && corOpala4x5 == "azul" && corOpala5x5 == "azul")
        {
            GUI.color = Color.blue;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 80, 30, 30), "L"))
        {
            corOpala2x5 = "azul";
        }
        GUI.color = Color.white;
                                                //--------^ OPALA  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 80, 30, 30), "s");
        GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 80, 30, 30), "B");
        //Terceira linha de botoes
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 110, 30, 30), "T");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 110, 30, 30), "H");
                                              //--------v HULK v-------//
        if (corHulk3x3 == "verde" && corHulk4x2 == "verde" && corHulk5x1 == "verde")
        {
            GUI.color = Color.green;
        }
        if(GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 110, 30, 30), "L")){
            corHulk3x3 = "verde";
        }
        GUI.color = Color.white;
                                            //--------^ HULK  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 110, 30, 30), "A");
                                           //--------v OPALA v-------//
        if (corOpala3x5 == "azul" && corOpala4x5 == "azul" && corOpala5x5 == "azul")
        {
            GUI.color = Color.blue;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 110, 30, 30), "A"))
        {
            corOpala3x5 = "azul";
        }
        GUI.color = Color.white;
                                            //--------^ OPALA  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 110, 30, 30), "T");
                                            //--------v FEIO v-------//
        if (corFeio3x7 == "vermelho")
        {
            GUI.color = Color.red;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 110, 30, 30), "F"))
        {
            corFeio3x7 = "vermelho";
        }
        GUI.color = Color.white;
                                            //--------^ FEIO ^-------//
        //----------------------------------v Quarta linha de botoe v--------------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 140, 30, 30), "O");
                                           //--------v HULK v-------//
        if (corHulk4x2 == "verde" && corHulk5x1 == "verde")
        {
            GUI.color = Color.green;
        }
        if(GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 140, 30, 30), "U"))
        {
            corHulk4x2 = "verde";
        }
        GUI.color = Color.white;
                                            //--------^ HULK  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 140, 30, 30), "P");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 140, 30, 30), "Q");
                                            //--------v OPALA v-------//
        if (corOpala4x5 == "azul" && corOpala5x5 == "azul")
        {
            GUI.color = Color.blue;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 140, 30, 30), "P"))
        {
            corOpala4x5 = "azul";
        }
        GUI.color = Color.white;
                                            //--------^ OPALA  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 140, 30, 30), "W");
                                           //--------v FEIO v-------//
        if (corFeio4x7 == "vermelho" && corFeio3x7 == "vermelho")
        {
            GUI.color = Color.red;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 140, 30, 30), "E"))
        {
            corFeio4x7 = "vermelho";
        }
        GUI.color = Color.white;
                                            //--------^   FEIO  ^-------//
        //----------------------------------Quinta linha de botoes--------------------------------------------------//
                                            //--------v HULK v-------//
        if (corHulk5x1 == "verde")
        {
            GUI.color = Color.green;
        }
        if(GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 170, 30, 30), "H"))
        {
            corHulk5x1 = "verde";
        }
        GUI.color = Color.white;
                                            //--------^ HULK  ^-------//
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 170, 30, 30), "L");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 170, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 170, 30, 30), "L");
                                        //--------v OPALA v-------//
        if (corOpala5x5 == "azul")
        {
            GUI.color = Color.blue;
        }
        if(GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 170, 30, 30), "O"))
        {
            corOpala5x5 = "azul";
        }
        GUI.color = Color.white;
                                        //--------^ OPALA  ^-------//
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 170, 30, 30), "O");
                                        //--------v FEIO v-------//
        if (corFeio5x7 == "vermelho"  && corFeio4x7 == "vermelho" && corFeio3x7 == "vermelho")
        {
            GUI.color = Color.red;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 170, 30, 30), "i"))
        {
            corFeio5x7 = "vermelho";
        }
        GUI.color = Color.white;
                                        //--------^ FEIO ^-------//
        //----------------------------------Sexta linha de botoes-------------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 200, 30, 30), "P");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 200, 30, 30), "Y");
        GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 200, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 200, 30, 30), "Q");
        GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 200, 30, 30), "O");
        GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 200, 30, 30), "U");
                                        //--------v FEIO v-------//
        if (corFeio6x7 == "vermelho" && corFeio5x7 == "vermelho" && corFeio4x7 == "vermelho" && corFeio3x7 == "vermelho")
        {
            GUI.color = Color.red;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 200, 30, 30), "O"))
        {
            corFeio6x7 = "vermelho";
        }
        GUI.color = Color.white;
                                        //--------^ FEIO ^-------//
        //----------------------------------Ultima linha de botoes-------------------------------------------------//
        GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 6) + 230, 30, 30), "Q");
        GUI.Button(new Rect((Screen.width / 2) - 20, (Screen.height / 6) + 230, 30, 30), "U");
                                        //--------v FUSCA v-------//
        if (corFusca7x3 == "magenta")
        {
            GUI.color = Color.magenta;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 10, (Screen.height / 6) + 230, 30, 30), "F"))
        {
            corFusca7x3 = "magenta";
        }
        GUI.color = Color.white;
                                        //--------^ FUSCA  ^-------//
                                        //--------v FUSCA v-------//
        if (corFusca7x4 == "magenta" && corFusca7x3 == "magenta")
        {
            GUI.color = Color.magenta;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 40, (Screen.height / 6) + 230, 30, 30), "U"))
        {
            corFusca7x4 = "magenta";
        }
        GUI.color = Color.white;
                                        //--------^ FUSCA  ^-------//
                                        //--------v FUSCA v-------//
        if (corFusca7x5 == "magenta" && corFusca7x4 == "magenta" && corFusca7x3 == "magenta")
        {
            GUI.color = Color.magenta;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 70, (Screen.height / 6) + 230, 30, 30), "S"))
        {
            corFusca7x5 = "magenta";
        }
        GUI.color = Color.white;
                                    //--------^ FUSCA  ^-------//
                                    //--------v FUSCA v-------//
        if (corFusca7x6 == "magenta" && corFusca7x5 == "magenta" && corFusca7x4 == "magenta" && corFusca7x3 == "magenta")
        {
            GUI.color = Color.magenta;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 100, (Screen.height / 6) + 230, 30, 30), "C"))
        {
            corFusca7x6 = "magenta";
        }
        GUI.color = Color.white;
                                    //--------^ FUSCA  ^-------//
                                    //--------v FUSCA v-------//
        if (corFusca7x7 == "magenta" && corFusca7x6 == "magenta" && corFusca7x5 == "magenta" && corFusca7x4 == "magenta" && corFusca7x3 == "magenta")
        {
            GUI.color = Color.magenta;
        }
        if (GUI.Button(new Rect((Screen.width / 2) + 130, (Screen.height / 6) + 230, 30, 30), "A"))
        {
            corFusca7x7 = "magenta";
        }
        GUI.color = Color.white;
                                //--------^ FUSCA  ^-------//
                                //--------Botao sair-------//
        if (GUI.Button(new Rect((Screen.width / 2) + 30, (Screen.height / 6) + 340, 60, 30), "sair"))
        {
            Application.Quit();
        }
    }
}
