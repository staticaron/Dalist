using UnityEngine;

public class AddNewCard : MonoBehaviour
{
	public GameObject cardContainer;
	public GameObject sampleCard;

	public void Clicked()
	{
		GameObject createdCard = Instantiate(sampleCard);
		createdCard.transform.SetParent(cardContainer.transform);
	}
}
