using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HandCard : MonoBehaviour
{
	[Header("共通のカードリスト"), SerializeField]
	PublicCardList PublicCardList;

	public List<CardSetting> GetPublicCardList()
	//大本のカードリストをいじってほしくないのでカードを増やすときに呼ばれるこいつのみ、パブリックカードリストを持つ
	//又貸しみたいなことしてるけどほかで絶対触ってほしくないため
	{
		return PublicCardList.GetCardList();
	}

	public List<CardSetting> DistributeCard(List<CardSetting> cardList, int handsNumber)
	//カードリストの中から手札に加えるカードを選ぶ関数(大本のカードリスト、増やす枚数)
	{
		List<CardSetting> cards = new();
		for(int i = 0; i < handsNumber; i++)
		{
			//ランダムで手札を決め、それを手札に加える
			int rand = Random.Range(1, (cardList.Count + 1));

			//億が１にもあり得てはいけない話だけども、もしもIDかぶりがあったとき、二つ以上帰ってくるからAddRange
			cards.AddRange(cardList.Where(card => card.GetID() == rand));
		}
		return cards;
	}
}
