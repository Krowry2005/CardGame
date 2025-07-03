using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
[CreateAssetMenu(fileName = "CardList", menuName = "CreateCardList")]
public class PublicCardList:ScriptableObject
{
	//大本のカードリストを作る
	[SerializeField]
	private List<Card> publicCardList = new();

	public List<Card> GetCardList()
	{
		return publicCardList;
	}
}
