using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
	[Header("�ŏ���HP"), SerializeField]
	int m_initHP;

	[Header("�ŏ���MP"), SerializeField]
	int m_initMP;

	[Header("�ŏ��́�"),SerializeField]
	int m_initMoney;

	[Header("�����Ă���J�[�h���X�g")]
	List<Card> m_cardList = new();


	public void RemoveCard(Card card)
	{
		//�����Ă���J�[�h���X�g����J�[�h�����炷
		m_cardList.Remove(card);
	}




}
