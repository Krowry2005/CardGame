using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class ViewCard : MonoBehaviour
{
	[Header("画像を保持している"),SerializeField]
	LoadSprite m_loadSprite;

	[Header("表示するもの"),SerializeField]
	GameObject m_card;

	[Header("エクセルで作ったカードのデータ"),SerializeField]
	CardBase m_cardBase;

	[Header("ScrollviewのContentを選択"),SerializeField]
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
		//表示前に全削除
		foreach (Transform n in m_cardView.transform)
		{
			Destroy(n.gameObject);
		}

		//クリックされたときの状態に応じて検索をかけたりする
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
				//すべてのカードの表示
				//なんかforeach使えんのでfor文で回す
				for(int i = 0; i < m_cardBase.dataArray.Length; i++)
				{
					//真っ白な画像を生成、保持
					GameObject card = Instantiate(m_card, m_cardView);

					//現在生成中のIDを使って画像を変化
					card.GetComponent<Image>().sprite = m_loadSprite.GetSprite(m_cardBase.dataArray[i].ID);
					card.GetComponent<CardData>().SetCard(m_cardBase.dataArray[i].ID);
				}
				break;

			default: //デフォルトでは


				break;
		}
	}
}
