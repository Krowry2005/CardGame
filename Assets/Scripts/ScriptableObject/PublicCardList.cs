using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
[CreateAssetMenu(fileName = "CardList", menuName = "CreateCardList")]
public class PublicCardList:ScriptableObject
{
	//��{�̃J�[�h���X�g�����
	[SerializeField]
	private List<Card> publicCardList = new();

	public List<Card> GetCardList()
	{
		return publicCardList;
	}
}
