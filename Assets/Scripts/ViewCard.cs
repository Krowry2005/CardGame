using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ViewCard : MonoBehaviour
{
	int m_id = 0;

	GameObject m_viewInfor;
	PublicCardList m_cardList;

	[SerializeField]
	Image m_image;

	[SerializeField]
	GameObject m_usedCard;

	public void Awake()
	{
		GetComponent<Button>().onClick.AddListener(OnClick);
		m_viewInfor = GameObject.FindGameObjectWithTag("ViewInfor");
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		m_cardList = gameController.GetComponent<PublicCardList>();
	}

	public void SetSprite(Sprite image)
	{
		m_image.sprite = image;
	}

	public void SetId(int id)
	{
		m_id = id;
	}

	public void OnClick()
	//�J�[�h���𐶐�����ID�ɕR�Â�������n��
	{
		//���ɏ�񂪊J����Ă�ꍇ�͍폜
		foreach(Transform parent in m_viewInfor.transform)
		{
			Destroy(parent.gameObject);
		}

		//�J�[�h�𐶐�
		GameObject usedCard = Instantiate(m_usedCard, m_viewInfor.transform);
		Debug.Log(m_image.sprite);
		Debug.Log(m_cardList.GetCard(m_id));
		usedCard.GetComponent<UsedCard>().SetInformation(m_image.sprite, m_cardList.GetCard(m_id));
	}
}
