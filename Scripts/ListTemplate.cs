using UnityEngine;

public class ListTemplate : MonoBehaviour
{
	public Transform cardContainer;

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

		Debug.Log(PointerManager.objectUnderPointer, PointerManager.objectUnderPointer);
	}
}
