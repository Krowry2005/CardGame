using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
[CreateAssetMenu(fileName = "CardList", menuName = "CreateCardList")]
public class PublicCardList:ScriptableObject
{
	//大本のカードリストを作る
	[SerializeField]
	private List<CardSetting> publicCardList = new();

	public List<CardSetting> GetCardList()
	{
		return publicCardList;
	}
}
