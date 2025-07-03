using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
	[Header("最初のHP"), SerializeField]
	int m_initHP;

	[Header("最初のMP"), SerializeField]
	int m_initMP;

	[Header("最初の￥"),SerializeField]
	int m_initMoney;

	[Header("持っているカードリスト")]
	List<Card> m_cardList = new();


	public void RemoveCard(Card card)
	{
		//持っているカードリストからカードを減らす
		m_cardList.Remove(card);
	}




}
