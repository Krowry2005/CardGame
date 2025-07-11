using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class User : MonoBehaviour
{
	public enum Attribute
	{
		None,       //無、もしくは物理
		Fire,       //炎
		Wind,       //風
		Water,      //水
		Soil,       //土
		Electric,   //電気
		Dark,       //闇
		Bright,     //光	
	}

	[Header("最初のHP"), SerializeField]
	int m_initHP;

	[Header("最初のMP"), SerializeField]
	int m_initMP;

	[Header("最初の￥"),SerializeField]
	int m_initMoney;

	[Header("最初の手札の数"), SerializeField]
	int m_numberHands;

	[Header("持っているカードリスト")]
	List<CardSetting> m_cardList = new();

	[Header("再使用可能なカード")]
	List<CardSetting> m_reUseCardList = new();

	int m_hp;
	int m_mp;

	HandCard m_handCard;

	private void Awake()
	{
		m_handCard = GameObject.FindGameObjectWithTag("GameController").GetComponent<HandCard>();
	}

	private void Start()
	{
		//最初の手札
		m_handCard.DistributeCard(m_handCard.GetPublicCardList(),m_numberHands);
		m_hp = m_initHP;
		m_mp = m_initMP;
	}

	public void UseCard(CardSetting card)
	{
		if(card.GetReUseApproval()) m_reUseCardList.Add(card);
		//持っているカードリストからカードを減らす
		m_cardList.Remove(card);
		SortList();
	}

	public void IncreaseCard(int num)
	{
		for(int i = 0; i < num; i++)
		{
			//手札に加える
			m_cardList.AddRange(m_handCard.DistributeCard(m_handCard.GetPublicCardList(), num));
		}
		SortList();
	}

	public void OnDamage(int damage)
	{
		if (m_hp <= 0) return;
		m_hp -= damage;
	}

	public void OnDeath()
	{

	}

	public void SortList()  //リストのソート
	{
		// GameObjectとSampleScriptのペアを先に作っておく（GetComponentは1回だけ）
		var objectScriptPairs = m_cardList
			.Select(card => new { card, script = card.GetComponent<CardSetting>() })
			.ToList();

		// SampleScript.hp を使って降順ソート（値が大きい順）
		objectScriptPairs.Sort((a, b) => b.script.GetID().CompareTo(a.script.GetID()));

		// ソート結果からGameObjectのリストだけに再構成
		m_cardList = objectScriptPairs.Select(pair => pair.card).ToList();
	}
}
