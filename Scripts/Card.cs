using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
	public TMP_InputField thisData;
	public Button thisActivatorButton;

	public void Clicked()
	{
		thisActivatorButton.gameObject.SetActive(false);
		thisData.ActivateInputField();
	}

	public void ClickedOutside()
	{
		thisActivatorButton.gameObject.SetActive(true);
	}
}
