using UnityEngine;

public class NewList : MonoBehaviour
{
	public GameObject ListContainer;        //Stores a reference to the List Container
	public GameObject SampleList;           //SampleList gameobject that can be modified

	public void CreateList()
	{
		GameObject createdList = Instantiate(SampleList);
		createdList.transform.SetParent(ListContainer.transform, false);    //Set the parent

		createdList.transform.localScale = new Vector3(3, 3, 3);        //Sets a size so that it fits the screen

		SendNewButtonToLast();      //Set the new List position at last

		SaveBoard.numberOfList = SaveBoard.numberOfList + 1;        //Update the data
	}

	void SendNewButtonToLast()
	{
		this.transform.SetParent(null);
		this.transform.SetParent(ListContainer.transform);
	}
}
