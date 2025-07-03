using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardStatus : MonoBehaviour
{
	[Header("※必ずm_cardに対応する型のカードを入れること"),SerializeField]
	Card m_card;

	[SerializeField]
	AttackCard m_attackCard;

	[SerializeField]
	DefenseCard m_defenseCard;

	[SerializeField]
	BothCard m_bothCard;

	[SerializeField]
	SpriteRenderer m_spriteRenderer;

	[SerializeField]
	TextMeshProUGUI m_textMeshProUGUI;

	private void Start()
	{
		m_spriteRenderer.sprite = m_card.GetCardImage();

		switch (m_card.GetCardType())
		{
			case Card.CardType.Attack:
				m_textMeshProUGUI.text = "<color=red>ATK</color>" + "<color=red>"+m_attackCard.GetAttack()+"</color>";
				break;

			case Card.CardType.Defense:
				m_textMeshProUGUI.text = "<color=blue>DEF</color>" + "<color=red>" +m_defenseCard.GetDefense()+ "</color>";
				break;

			case Card.CardType.Both:
				m_textMeshProUGUI.text = "<color=red>A</color>" + "<color=red>" + m_bothCard.GetAttack() + "</color>" + "<color=blue>D</color>" + "<color=blue>" + m_bothCard.GetDefense() + "</color>";
				break;
		}

	}
}
