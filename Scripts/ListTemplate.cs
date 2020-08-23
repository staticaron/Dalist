using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class ListTemplate : MonoBehaviour
{
	public Transform cardContainer;
	public TMP_InputField listName;
	public int creationIndex;

	private Vector3 defaultSize = Vector3.one * 3;

	public void setSize()
	{
		transform.localScale = defaultSize;
	}

	public void setName(string name)
	{
		listName.text = name;
	}

	public void PointerEntered()
	{
		if (PointerManager.isDragEnabled)
		{
			PointerManager.objectUnderPointer = cardContainer;
			print(PointerManager.objectUnderPointer.name);
		}
	}

	public void PointerLeft()
	{
		print("PointerLeft");

		if (PointerManager.isDragEnabled == true)
		{
			PointerManager.objectUnderPointer = null;
		}
	}



}
