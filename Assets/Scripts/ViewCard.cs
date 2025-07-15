using System.Collections.Generic;
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

	[Header("ここで保持してる変数をもとに表示するものも変化"),SerializeField]
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
		//クリックされたときの状態に応じて検索をかけたりする
		switch (m_cardType)
		{
			case CardType.Attack:

				break;



			case CardType.Length:
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
		}

	}

}
