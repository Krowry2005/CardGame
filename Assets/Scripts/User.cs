using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class User : MonoBehaviour
{
	public enum Attribute
	{
		None,       //���A�������͕���
		Fire,       //��
		Wind,       //��
		Water,      //��
		Soil,       //�y
		Electric,   //�d�C
		Dark,       //��
		Bright,     //��	
	}

	[Header("�ŏ���HP"), SerializeField]
	int m_initHP;

	[Header("�ŏ���MP"), SerializeField]
	int m_initMP;

	[Header("�ŏ��́�"),SerializeField]
	int m_initMoney;

	[Header("�ŏ��̎�D�̐�"), SerializeField]
	int m_numberHands;

	[Header("�����Ă���J�[�h���X�g")]
	List<CardSetting> m_cardList = new();

	[Header("�Ďg�p�\�ȃJ�[�h")]
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
		//�ŏ��̎�D
		m_handCard.DistributeCard(m_handCard.GetPublicCardList(),m_numberHands);
		m_hp = m_initHP;
		m_mp = m_initMP;
	}

	public void UseCard(CardSetting card)
	{
		if(card.GetReUseApproval()) m_reUseCardList.Add(card);
		//�����Ă���J�[�h���X�g����J�[�h�����炷
		m_cardList.Remove(card);
		SortList();
	}

	public void IncreaseCard(int num)
	{
		for(int i = 0; i < num; i++)
		{
			//��D�ɉ�����
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

	public void SortList()  //���X�g�̃\�[�g
	{
		// GameObject��SampleScript�̃y�A���ɍ���Ă����iGetComponent��1�񂾂��j
		var objectScriptPairs = m_cardList
			.Select(card => new { card, script = card.GetComponent<CardSetting>() })
			.ToList();

		// SampleScript.hp ���g���č~���\�[�g�i�l���傫�����j
		objectScriptPairs.Sort((a, b) => b.script.GetID().CompareTo(a.script.GetID()));

		// �\�[�g���ʂ���GameObject�̃��X�g�����ɍč\��
		m_cardList = objectScriptPairs.Select(pair => pair.card).ToList();
	}
}
