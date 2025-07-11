using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UsedCard : MonoBehaviour
{
	[SerializeField]
	GameObject usedCardAsset;

	[Header("選んだカードの表示場所"),SerializeField]
	Transform choiceCard;

	List<CardSetting> m_usedCardList = new();

	public void SetCard(CardSetting cardSetting)
	{
		m_usedCardList.Add(cardSetting);
		GameObject usedCard = Instantiate(usedCardAsset, Vector3.zero, Quaternion.identity, choiceCard) as GameObject;
		usedCard.GetComponent<Card>().SetCard(cardSetting);
	}
}
