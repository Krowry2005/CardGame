using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "CardSetting", menuName = "CreateCardSetting")]
public class CardSetting : ScriptableObject
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
		Item,
	}

	[SerializeField]
	int card_id = 0;

	[SerializeField]
	int Rare = 0;

	[SerializeField]
	Sprite card_image = null;

	[SerializeField]
	string card_display_name = null;

	[SerializeField]
	string card_name = null;

	[SerializeField]
	CardType card_type;

	[SerializeField, TextArea(1, 4)]
	string information = "1\n2\n3\n4";

	public int GetID()
	{ return card_id;}

	public Sprite GetCardImage()
	{ return card_image; }

	public int GetRare()
	{ return Rare;}

	public string GetDisplayName()
	{ return card_display_name;}

	public string GetName()
	{ return card_name;}

	public CardType GetCardType()
	{ return card_type;}

	public string GetInformation()
	{ return information;}
}


