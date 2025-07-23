using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PublicCardList : MonoBehaviour
{
	[SerializeField]
	CardBase m_publicCard;

	public CardBaseData GetCard(int id)
	{ return m_publicCard.dataArray[id]; }

	/*取得方法　プロパティで取得する*/
}


