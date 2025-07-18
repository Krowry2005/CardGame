using System.Collections.Generic;
using Unity.Burst.Intrinsics;
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

	CardType m_cardType;

	private void Awake()
	{
		
	}

	private void Start()
	{
	}

	public void OnClick()
	{
		//�\���O�ɑS�폜
		foreach (Transform n in m_cardView.transform)
		{
			Destroy(n.gameObject);
		}

		//�N���b�N���ꂽ�Ƃ��̏�Ԃɉ����Č������������肷��
		switch (m_cardType)
		{
			case CardType.Attack:

				break;

			case CardType.Defence:

				break;

			case CardType.Magic:

				break;

			case CardType.Spirit:

				break;

			case CardType.All:
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

			default: //�f�t�H���g�ł�


				break;
		}
	}
}
