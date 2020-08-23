using UnityEngine;
using System.Collections.Generic;

public class SaveManager : MonoBehaviour
{
	public static int numberOfLists = 3;
	public static List<string> nameOfLists = new List<string>() { "Name", "Class", "RollNumber" };
	public static List<List<string>> nameOfCards = new List<List<string>>() { new List<string>() { "Dev", "Azhan" }, new List<string>() { "12", "12" }, new List<string>() { "7", "10" } };

	public void SaveBoard()
	{
		//Create the object that needs to be saved
		BoardData boardToSave = new BoardData(numberOfLists, nameOfLists, nameOfCards);

		//Save the board
		SaveSystem.SaveTheBoard(boardToSave, "Sample");
	}
}
