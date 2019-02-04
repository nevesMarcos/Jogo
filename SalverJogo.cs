using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SalverJogo : MonoBehaviour
{
    public static float tempo;
    public static float cronometro;
    private void Start()
    {
        cronometro = 0;
        
    }
    //Conta o tempo gasto e salva o menor tempo para achar todas as palavras
    private void Update()
    {
        if (Sensores.contar == true)
        {
            cronometro += Time.deltaTime;
        }
        
        if (cronometro > tempo)
        {
            PlayerPrefs.SetFloat("tempoMenor", cronometro);
            tempo = PlayerPrefs.GetFloat("tempoMenor");
        }
    }
}

