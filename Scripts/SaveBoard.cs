using UnityEngine;
using System.Collections.Generic;

public class SaveBoard : MonoBehaviour
{
	public static int numberOfList;
	public static List<BoardList> lists;

	void Start()
	{
		try
		{
			numberOfList = SaveSystem.loadBoard(PlayerPrefs.GetString("CurrentProject")).numberOfLists;
			lists = SaveSystem.loadBoard(PlayerPrefs.GetString("CurrentProject")).lists;
		}
		catch
		{
			print("Error getting data");
		}
	}

	public void Save()
	{
		SaveSystem.SaveData("SampleProject", numberOfList, new List<BoardList>() { new BoardList("MyList", new string[] { "HelloCard" }), new BoardList("Another list", new string[] { "SampleCard", "Another sample card" }) });
	}

	public void PrintSaveData()
	{
		BoardData boardData = SaveSystem.loadBoard("SampleProject");

		print(boardData.numberOfLists);
	}
}