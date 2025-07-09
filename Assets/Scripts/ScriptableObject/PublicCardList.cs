using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
[CreateAssetMenu(fileName = "CardList", menuName = "CreateCardList")]
public class PublicCardList:ScriptableObject
{
	//��{�̃J�[�h���X�g�����
	[SerializeField]
	private List<CardSetting> publicCardList = new();

	public List<CardSetting> GetCardList()
	{
		return publicCardList;
	}
}
