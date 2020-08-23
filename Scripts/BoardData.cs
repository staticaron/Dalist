using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public struct BoardList
{
	public string listName;     //Stores the name of the list
	public string[] cardData;       //Stores the data of all the cards inside that list

	public BoardList(string name, string[] cards)
	{
		this.listName = name;
		this.cardData = cards;
	}
}

[System.Serializable]
public class BoardData
{
	public int numberOfLists;       //Number of lists
	public List<BoardList> lists;        //All the lists those were saveds

	public BoardData(int numberOfList, List<BoardList> allTheLists)
	{
		//Assign the data list
		this.numberOfLists = numberOfList;
		this.lists = allTheLists;
	}
}
