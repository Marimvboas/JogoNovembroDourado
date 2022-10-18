using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparaSintomas : MonoBehaviour
{
    public static string palavra1="1", palavra2="2";
    public static bool acertou = false;
    public static int count = 0;
    //public static GameObject setaVerde;

    public static void ChecarAcerto()
    {
        //if(apertou2){
            if(palavra1.Equals(palavra2))
            {    
                Debug.Log("São iguais");
                acertou = true;
                count++; //conta a quantidade de acertos
            }
            else
            {
                acertou = false;
                BotaoSintomaPaciente.botaoAcionado = null;
                Debug.Log("São diferentes");
            }
        //}
        if(count == 3){
            //
            //GameObject.Find("SetaVerde").SetActive(true);
            GameObject.Find("SetaVerde").transform.GetChild(0).gameObject.GetComponent<Text>().text = "Finalizar Consulta";
            Debug.Log("Acertou os três sintomas");
            MouseEmboloSangue.finalizou = false;
        } else {
            //GameObject.Find("SetaVerde").SetActive(true);
            GameObject.Find("SetaVerde").transform.GetChild(0).gameObject.GetComponent<Text>().text = "Chamar Paciente";
        }
    }
}
