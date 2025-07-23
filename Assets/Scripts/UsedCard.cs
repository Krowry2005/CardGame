using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class UsedCard : MonoBehaviour
{
	[SerializeField]
	Image m_image;

	[SerializeField]
	TextMeshProUGUI m_name;

	[SerializeField]
	TextMeshProUGUI m_value;

	[SerializeField]
	TextMeshProUGUI m_miniInformation;

	public void SetInformation(Sprite sprite,Å@CardBaseData cardBaseData)
	{
		m_image.sprite = sprite;
		m_name.text = cardBaseData.Name_JP;
		m_miniInformation.text = cardBaseData.Information;

		if (!cardBaseData.Valuecard)
		{
			m_value.text = null;
		}
		else
		{
			switch(cardBaseData.CARDTYPE)
			{
				case CardType.Attack:
					m_value.text = "Attack : " + cardBaseData.Value.ToString();
					break;

				case CardType.Defense:
					m_value.text = "Defense : " + cardBaseData.Value.ToString();
					break;

				case CardType.Magic:
					switch (cardBaseData.Magictype)
					{
						case "Attack":
							m_value.text = cardBaseData.Magictype + cardBaseData.Value.ToString();
							break;
					
					}
					break;

				case CardType.Heal:
					m_value.text = "Heal : " + cardBaseData.Value.ToString();
					break;
			}

		}
	}


}
