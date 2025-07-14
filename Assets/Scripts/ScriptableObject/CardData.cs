
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "ScriptableObject/CardData")]
[Serializable]
public class CardData : ScriptableObject
{
	public enum CardType
	{
		Attack,
		Defence,
		Magic,
		Spirit
	}

	[SerializeField]
	CardType m_cardType;

	[SerializeField]
	int m_id;

	[SerializeField]
	string m_name;

	[SerializeField]
	Sprite m_sprite;

	[SerializeField]
	string m_information;

	[SerializeField]
	string m_miniInformation;

	public CardType GetCardType() { return m_cardType; }

	public int GetID() { return m_id; }

	public string GetName() { return m_name; }

	public Sprite GetSprite() { return m_sprite; }

	public string GetInformation() { return m_information; }

	public string GetMinimumInfo() { return m_miniInformation; }
}

