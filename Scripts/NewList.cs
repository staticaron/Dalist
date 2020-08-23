using UnityEngine;

public class NewList : MonoBehaviour
{
	public GameObject ListContainer;        //Stores a reference to the List Container
	public GameObject SampleList;           //SampleList gameobject that can be modified

	public void CreateList()
	{
		GameObject createdList = Instantiate(SampleList);
		createdList.transform.SetParent(ListContainer.transform);    //Set the parent
		SendNewButtonToLast();
	}

	void SendNewButtonToLast()
	{
		this.transform.SetParent(null);
		this.transform.SetParent(ListContainer.transform);
	}
}
