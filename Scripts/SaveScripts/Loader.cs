using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
	public Transform listContainer;
	public GameObject listTemplate;

	void Start()
	{
		string loadPath = Application.persistentDataPath + "/" + "Sample" + ".txt";

		if (File.Exists(loadPath))
		{
			BoardData boardToLoad = SaveSystem.LoadBoard("Sample");
			LoadBoard(boardToLoad);
		}
		else {
			SceneManager.LoadScene("MainMenu");
			Debug.Log("File not found");
		}
	}

	public void LoadBoard(BoardData boardToLoad)
	{
		/// <summary>
		/// 1. Create the correct number of lists
		/// 2. Assign the correct Names
		/// 3. Create correct cards
		/// </summary>

		for (int i = 0; i < boardToLoad.creationIndex; i++)
		{
			GameObject createdList = Instantiate(listTemplate);
			createdList.transform.SetParent(listContainer);

			ListTemplate createdListScript = createdList.GetComponent<ListTemplate>();
			createdListScript.setSize();
			createdListScript.creationIndex = i;
			createdListScript.setName(boardToLoad.nameOfLists[i]);
		}

	}
}
