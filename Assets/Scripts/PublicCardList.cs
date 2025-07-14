using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PublicCardList : MonoBehaviour
{
	[SerializeField]
	List<CardData> m_publicCardList = new();

	private void Start()
	{
		Debug.Log(GetCard(0).GetName());
	}

	public CardData GetCard(int id)
	{
		return m_publicCardList[id];
	}
}


