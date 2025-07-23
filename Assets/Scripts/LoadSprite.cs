using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LoadSprite : MonoBehaviour
{
	List<Sprite> m_imageList = new();

	private void Awake()
	{
		//Resources�t�@�C���ɑ��݂��邷�ׂẲ摜���擾
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
