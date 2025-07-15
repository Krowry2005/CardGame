using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewCard : MonoBehaviour
{
	[Header("�摜��ێ����Ă���"),SerializeField]
	LoadSprite m_loadSprite;

	[Header("�\���������"),SerializeField]
	GameObject m_card;

	[Header("�G�N�Z���ō�����J�[�h�̃f�[�^"),SerializeField]
	CardBase m_cardBase;

	[Header("Scrollview��Content��I��"),SerializeField]
	Transform m_cardView;

	[Header("�����ŕێ����Ă�ϐ������Ƃɕ\��������̂��ω�"),SerializeField]
	CardType m_cardType;

	private void Awake()
	{
		
	}

	private void Start()
	{
		m_cardType = CardType.Length;
	}


	public void OnClick()
	{
		//�N���b�N���ꂽ�Ƃ��̏�Ԃɉ����Č������������肷��
		switch (m_cardType)
		{
			case CardType.Attack:

				break;



			case CardType.Length:
				//���ׂẴJ�[�h�̕\��
				//�Ȃ�foreach�g����̂�for���ŉ�
				for(int i = 0; i < m_cardBase.dataArray.Length; i++)
				{
					//�^�����ȉ摜�𐶐��A�ێ�
					GameObject card = Instantiate(m_card, m_cardView);

					//���ݐ�������ID���g���ĉ摜��ω�
					card.GetComponent<Image>().sprite = m_loadSprite.GetSprite(m_cardBase.dataArray[i].ID);
					card.GetComponent<CardData>().SetCard(m_cardBase.dataArray[i].ID);
				}
				break;
		}

	}

}
