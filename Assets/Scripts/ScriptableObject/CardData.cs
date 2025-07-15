
using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour 
{
	int m_cardID;

	public int GetID()
	{
		return m_cardID;
	}

	public void SetCard(int id)
	{
		m_cardID = id;
	}

	public void OnClick()
	{

	}
}





