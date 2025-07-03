using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Card", menuName = "CreateCard")]
public class Card : ScriptableObject
{
	public enum CardType
	{
		Attack,
		Defense,
		Both,
		Heal,
		State,
		Magic,
		Spirit,
	}

	[SerializeField]
	int card_id;

	[SerializeField]
	Sprite card_image;

	[SerializeField]
	string card_display_name;

	[SerializeField]
	string card_name;

	[SerializeField]
	CardType card_type;

	[SerializeField]
	string potency;

	public int GetID()
	{ return card_id;}

	public Sprite GetCardImage()
	{ return card_image; }

	public string GetDisplayName()
	{ return card_display_name;}

	public string GetName()
	{ return card_name;}

	public CardType GetCardType()
	{ return card_type;}

	public string GetPotency()
	{ return potency;}
}


