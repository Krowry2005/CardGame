using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LoadSprite : MonoBehaviour
{
	List<Sprite> m_imageList = new();

	private void Awake()
	{
		//Resourcesファイルに存在するすべての画像を取得
		m_imageList.AddRange(Resources.LoadAll<Sprite>("Card"));
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
