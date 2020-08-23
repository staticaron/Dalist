using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
	private TMP_InputField thisCard;

	void Awake()
	{
		thisCard = GetComponent<TMP_InputField>();
	}

	public void Clicked()
	{
		thisCard.enabled = true;
		thisCard.ActivateInputField();
	}
}
