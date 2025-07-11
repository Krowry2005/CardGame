using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	CardSetting m_cardSetting;

	private void Awake()
	{
		
	}

	private void Start()
	{
		
	}

	public void OnClick()
	{
		
	}

	public void DisplayUpdate()
	{
		gameObject.GetComponent<Image>().sprite = m_cardSetting.GetCardImage();
	}

	public void SetCard(CardSetting card)
	{
		m_cardSetting = card;
	}
}