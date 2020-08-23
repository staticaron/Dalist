using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class MainMenu : MonoBehaviour
{
	public TMP_InputField createBoardNameInput;     //reference to the project name taker

	void Start()
	{
		print(PlayerPrefs.GetString("CurrentProject"));
	}

	public void Create()
	{
		string boardName = createBoardNameInput.text;       //Get the boardName
		string filePath = Application.persistentDataPath + "/" + boardName + ".dls";

		if (string.IsNullOrEmpty(boardName))
		{
			print("Please enter some name");
			return;
		}
		else {
			if (File.Exists(filePath))
			{
				print("File already exist");
				return;
			}
		}

		//If control reached here, the new file can be created

		PlayerPrefs.SetString("CurrentProject", boardName);

		//Load empty template
		SceneManager.LoadScene("EmptyTemplate");
	}

	public void Load()
	{
		SceneManager.LoadScene("SavedBoard");
	}
}
