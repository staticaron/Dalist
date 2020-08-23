using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
	public static void SaveTheBoard(BoardData boardToSave, string fileName)
	{
		string savePath = Application.persistentDataPath + "/" + fileName + ".txt";

		//Create an empty file
		FileStream stream = new FileStream(savePath, FileMode.Create);

		//Create a formatter
		BinaryFormatter formatter = new BinaryFormatter();

		//Write the data
		formatter.Serialize(stream, boardToSave);

		//Close the file
		stream.Close();

		print("Saved Data" + boardToSave.creationIndex);
	}

	public static BoardData LoadBoard(string fileName)
	{
		string loadPath = Application.persistentDataPath + "/" + fileName + ".txt";

		FileStream saveFile = new FileStream(loadPath, FileMode.Open, FileAccess.Read);

		//Create a formatter
		BinaryFormatter formatter = new BinaryFormatter();

		//Get the data from the save File
		BoardData loadBoardData = (BoardData)formatter.Deserialize(saveFile);

		return loadBoardData;
	}
}
