using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
	public static void SaveData(string projectName, int numberOfList, List<BoardList> lists)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();

		string savePath = Application.persistentDataPath + "/" + projectName + ".dls";

		FileStream stream = new FileStream(savePath, FileMode.Create);

		BoardData thisBoardData = new BoardData(numberOfList, lists);

		binaryFormatter.Serialize(stream, thisBoardData);

		stream.Close();
	}

	public static BoardData loadBoard(string boardFile)
	{
		string savePath = Application.persistentDataPath + "/" + boardFile + ".dls";

		Debug.Log(savePath);

		if (!File.Exists(savePath))
		{
			Debug.Log("Save File not found");

			return null;
		}
		else {
			BinaryFormatter binaryFormatter = new BinaryFormatter();        //Get the formatter

			FileStream stream = new FileStream(savePath, FileMode.Open);        //Select the file

			BoardData boardData = (BoardData)binaryFormatter.Deserialize(stream);       //Extract the data from it

			stream.Close();         //Close the file

			return boardData;       //return the loaded data
		}
	}
}
