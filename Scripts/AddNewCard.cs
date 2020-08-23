using UnityEngine;

public class AddNewCard : MonoBehaviour
{
	public GameObject cardContainer;
	public GameObject sampleCard;

	public void Clicked()
	{
		GameObject createdCard = Instantiate(sampleCard);
		createdCard.transform.SetParent(cardContainer.transform);       //Set parent to card container

		Card thisCard = createdCard.GetComponent<Card>();
		thisCard.setSize();        //Maintain same size for all aspects
		thisCard.currentlyAttached = cardContainer.transform;
	}
}
