using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoCasa : MonoBehaviour
{
    string[] dialogocasa = new string[] { "O m�dico retorna ao seu lar chique e elegante, Juliete o est� aguardando e o convida a se sentar no sof�. Nele, ambos se olham tristes, e ela mostra sua preocupa��o, pois hoje completa um ano da morte da filha deles, a Amanda. Ela fala sobre a perda de sua filha e como pensa nela todos os dias, apreciando os momentos que puderam aproveitar juntas. Os dois lamentam a perda de sua filha juntos, por�m  ela tamb�m fala da import�ncia do trabalho dele, ajudando as crian�as a se prevenir contra a mesma enfermidade que levou a Amanda." };

	public GameObject spechBaloon;
	string[] dialogos; 
	public float typingSpeed;
	public bool activecontrol, digite;
	public static int iP;
	public Text spechBaloonText;

	public void Start()
	{
		
	}

	public void Falas(string[] txt)
	{
		spechBaloon.SetActive(true);
		dialogos = txt;
		StartCoroutine(TypingDialogues());
		digite = false;
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
				spechBaloonText.text = "";
				spechBaloon.SetActive(false);
			}
			else
			{
				spechBaloonText.text = "";
				iP = 0;
				spechBaloon.SetActive(false);
			}
		} else
        {
			typingSpeed = 0;
			digite = false;
        }
	}

	public void Update()
	{
		if (digite == true)
			Falas(dialogocasa);
		if (Input.GetMouseButtonDown(0))
		{
			NextSentence();
		}
	}
}
