using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoPaciente : MonoBehaviour
{
	//Script Inspirado no script criado pelo canal do Youtube "Crie Seus Jogos"
	public GameObject spechBaloon, nextBalloon;
	string[] dialogos;
	public float typingSpeed;
	public bool activecontrol;
	public static int iP;
	public Text spechBaloonText;

    public void Start()
    {
		Falas(Dialogo1.dialogues);
		activecontrol = true;
	}

    public void Falas(string[] txt)
	{
		spechBaloon.SetActive(true);
		dialogos = txt;
		StartCoroutine(TypingDialogues());
	}

	IEnumerator TypingDialogues()
	{
		foreach (char character in dialogos[iP].ToCharArray())
		{
			spechBaloonText.text += character;
			yield return new WaitForSeconds(typingSpeed);
		}
	}

	public void NextSentence()
	{
		if (spechBaloonText.text == dialogos[iP])
		{
			if (iP < dialogos.Length - 1)
			{
				iP++;
				spechBaloonText.text = "";
				spechBaloon.SetActive(false);
			}
			else
			{
				spechBaloonText.text = "";
				iP = 0;
				spechBaloon.SetActive(false);
			}
		}
	}

    public void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			NextSentence();			
		}
	}
}

public static class Dialogo1
{
	public static string dialogue1 = "Meu filho sentiu muita \bfebre\b � noite esses dias, ent�o eu vim logo para ver o qu� que ele tem, minha fam�lia inteira vivia indo ao m�dico na inf�ncia. Agora ele come�ou a \bco�ar a pele\b, coitado. Ele tem faltado aula por causa disso, ent�o eu sei que ele t� bem feliz, mas tem que saber se ele t� bem n�, doutor!";
	public static string dialogue2 = "Nossa, quem diria! Muito obrigado, doutor!";

	public static string dialogue3 = "";
	public static string dialogue4 = "";
	
	public static string dialogue5 = "";
	
	public static string[] dialogues= new string[2] { dialogue1, dialogue2 };
}

public static class Dialogo2
{
	public static string dialogue1 = "Vou fazer uma checagem nele em um instante";
	public static string dialogue2 = "Voc� fez certo em vir com anteced�ncia, � bem poss�vel que ele esteja com caso de Linfoma. O que acontece � que seu filho muito provavelmente tem o sistema imunol�gico comprometido por doen�as gen�ticas, o que estaria afetando os linf�citos do seu corpo. � preciso que voc� v� a um Ortopedista para checar qualquer incha�o nos revestimentos do pesco�o, axila ou virilha, como notei um pequeno aumento na regi�o do abd�men";
	
	public static string dialogue3 = "";
	public static string dialogue4 = "";
	
	public static string dialogue5 = "";
	
	public static string[] dialogues = new string[2] { dialogue1, dialogue2 };
}