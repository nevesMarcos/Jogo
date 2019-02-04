using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnRetorInicir : MonoBehaviour
{
    //Carrega a cena1 novamente
    public void OnMouseDown()
    {
        Sensores.contar = true;
        Sensores.contagem = 0;
        SceneManager.LoadScene("Cena1");
    }
}
