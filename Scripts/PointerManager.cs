using UnityEngine;

public class PointerManager : MonoBehaviour
{
	public static bool isDragEnabled;
	public static Transform objectUnderPointer;

	public static Transform canvas;

	void Awake()
	{
		canvas = GameObject.Find("Canvas").transform;
	}

	public static void SetParentCanvas()
	{
		objectUnderPointer = canvas;
	}
}
