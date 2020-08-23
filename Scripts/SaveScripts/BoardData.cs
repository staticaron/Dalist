using System.Collections.Generic;

[System.Serializable]
public class BoardData
{
	public int creationIndex;
	public List<string> nameOfLists;
	public List<List<string>> nameOfCards;

	public BoardData(int creationIndices, List<string> nameOfLists, List<List<string>> cards)
	{
		this.creationIndex = creationIndices;
		this.nameOfLists = nameOfLists;
		this.nameOfCards = cards;
	}
}

///summary
/// Board data script will contain all the data the needs to be saved to the file
/// Data that needs to be saved is :
/// 	1. Number of lists .../ So that loader can create corrent amount of lists
/// 	2. Name of all the lists .../ So that when creating lists, there names could be assigned properly
/// 	3. Number of cards .../ So that loader can create corrent amount of cards in each list
/// 	4. Name of all the cards .../ So that card's name could be assigned properly
/// Data will be assigned as : 
/// 	1.Whenever a new list is created, A specific number is assigned to it....That number is its creation order
/// 	2.Whenever a list is renamed, The list name, under the creation number, is changed accordingly
/// 	3.Whenever a card is created, its creation number is stored as well
/// 	4.Whenever a card is renamed, the corresponding value is changed in the list of cards
///summary
