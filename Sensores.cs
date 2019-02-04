using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Sensores : MonoBehaviour
{
    public Image sensorImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1, 0, 0, 1);
    public Color flashColor2 = new Color(1f, 0.92f, 0.016f, 1f);
    public Color flashColor3 = new Color(0f, 0f, 0f, 1f);
    public static bool sensorErro;
    public static bool sensorVitoria;
    public static float contagem = 0.0f;
    public static float recordd = 0.0f;
    public static float tempoFinal;
    public float tempo;
    public static bool contar = true;
    public static SalverJogo instance;
    public static float record;
    public static float valor = 0.0f;

    private void Start()
    {
        contagem = 300.0f;
    }
    // Update is called once per frame
    void Update()
    {
        //Checa se todas as palavras foram encontradas e chama a cenaVitoria, logo apos, ativar o sensor de vitoria e chamar o metodo para zerar todos campos
        if (MotorGame.corHulk5x1 == "verde" && MotorGame.corHulk4x2 == "verde" && MotorGame.corHulk3x3 == "verde" && MotorGame.corHulk2x4 == "verde")
        {
            if (MotorGame.corLoki1x1 == "amarelo" && MotorGame.corLoki1x2 == "amarelo" && MotorGame.corLoki1x3 == "amarelo" && MotorGame.corLoki1x4 == "amarelo")
            {
                if (MotorGame.corOpala5x5 == "azul" && MotorGame.corOpala4x5 == "azul" && MotorGame.corOpala3x5 == "azul" && MotorGame.corOpala2x5 == "azul" && MotorGame.corOpala1x5 == "azul")
                {
                    if (MotorGame.corFusca7x3 == "magenta" && MotorGame.corFusca7x4 == "magenta" && MotorGame.corFusca7x5 == "magenta" && MotorGame.corFusca7x6 == "magenta" && MotorGame.corFusca7x7 == "magenta")
                    {
                        contar = false;
                        contagem = 0;
                        sensorVitoria = true;
                        Zerar();
                        SceneManager.LoadScene("CenaVitoria");
                    }
                }
            }
        }
        //Checa se alguma palavra errada foi encontrada e ativa o sensor de erro, tambem chaa o metodo zerar()
        if (MotorGame.corFeio3x7 == "vermelho" && MotorGame.corFeio4x7 == "vermelho" && MotorGame.corFeio5x7 == "vermelho" && MotorGame.corFeio6x7 == "vermelho")
        {
            sensorErro = true;
            Zerar();
        }
       
        //Sensor de erro
        if (sensorErro)
        {
            sensorImage.color = flashColor;
        }
        else
        {
            sensorImage.color = Color.Lerp(sensorImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        sensorErro = false;
        //Sensor de vitoria
        if (sensorVitoria)
        {
            sensorImage.color = flashColor2;
        }
        else
        {
            sensorImage.color = Color.Lerp(sensorImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        sensorVitoria = false;
    }
    //Zera todos os campos 
    public void Zerar()
    {
        MotorGame.corFeio3x7 = " ";
        MotorGame.corFeio4x7 = " ";
        MotorGame.corFeio5x7 = " ";
        MotorGame.corFeio6x7 = " ";
        MotorGame.corFusca7x3 = " ";
        MotorGame.corFusca7x4 = " ";
        MotorGame.corFusca7x5 = " ";
        MotorGame.corFusca7x6 = " ";
        MotorGame.corFusca7x7 = " ";
        MotorGame.corHulk2x4 = " ";
        MotorGame.corHulk3x3 = " ";
        MotorGame.corHulk4x2 = " ";
        MotorGame.corHulk5x1 = " ";
        MotorGame.corLoki1x1 = " ";
        MotorGame.corLoki1x2 = " ";
        MotorGame.corLoki1x3 = " ";
        MotorGame.corLoki1x4 = " ";
        MotorGame.corOpala1x5 = " ";
        MotorGame.corOpala2x5 = " ";
        MotorGame.corOpala3x5 = " ";
        MotorGame.corOpala4x5 = " ";
        MotorGame.corOpala5x5 = " ";
    }
}
