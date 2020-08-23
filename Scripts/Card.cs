using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
	public TMP_InputField thisData;
	public Button thisActivatorButton;

	private Vector3 defaultCardSize = Vector3.one;

	public Transform currentlyAttached;

	public void Clicked()
	{
		thisActivatorButton.gameObject.SetActive(false);
		thisData.ActivateInputField();
	}

	public void ClickedOutside()
	{
		thisActivatorButton.gameObject.SetActive(true);
	}

	public void setSize()
	{

	}



	public void DragStarted()
	{
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void IsDragged()
	{
		if (PointerManager.isDragEnabled == false)
		{
			transform.SetParent(GameObject.Find("Canvas").transform);
		}

		PointerManager.isDragEnabled = true;

		Vector3 mousePos = Input.mousePosition;
		transform.position = mousePos;
	}

	public void DragEnded()
	{
		if (PointerManager.isDragEnabled)
		{

			/// <summary>
			/// If previously, the card was dragged, then release it
			/// </summary>

			PointerManager.isDragEnabled = false;

			if (PointerManager.objectUnderPointer != null)
			{
				transform.SetParent(PointerManager.objectUnderPointer);
				currentlyAttached = PointerManager.objectUnderPointer;
			}
			else {
				transform.SetParent(currentlyAttached);
			}
		}
		else {

			/// <summary>
			/// If previously, card was not dragged, but clicked then edit
			/// </summary>

			thisData.ActivateInputField();
		}

		setSize();
		transform.SetParent(currentlyAttached);
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
}
