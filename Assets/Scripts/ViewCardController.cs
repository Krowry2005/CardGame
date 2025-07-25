using System.Linq;
using UnityEngine;

public class ViewCardController : MonoBehaviour
{
	[SerializeField]
	LoadSprite m_loadSprite;

	[Header("画像の生成場所"), SerializeField]
	Transform m_parent;

	[Header("生成カード"), SerializeField]
	GameObject m_card;

	private void Awake()
	{

	}

	private void Start()
	{
		for (int i = 0; i < m_loadSprite.GetSpriteList().Count(); i++)
		{
			GameObject image = Instantiate(m_card, m_parent);
			ViewCard viewCard = image.GetComponent<ViewCard>();
			viewCard.SetSprite(m_loadSprite.GetSprite(i));
			viewCard.SetId(i);
		}
	}
}
