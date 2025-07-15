using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LoadSprite : MonoBehaviour
{
	List<Sprite> m_imageList = new();

	private void Awake()
	{
		m_imageList.AddRange(Resources.LoadAll<Sprite>(""));
		Debug.Log(m_imageList.Count());
	}

	public Sprite GetSprite(int id)
	{
		return m_imageList[id];
	}

	public List<Sprite> GetSpriteList()
	{
		return m_imageList; 
	}
}
