using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System.IO.MemoryMappedFiles;

public class test : MonoBehaviour
{
	[SerializeField]
	PublicCardList publicCardList;

	[SerializeField]
	List<GameObject> viewList = new();

	int rand;

	private void Start()
	{
		foreach(GameObject view in viewList)
		{
			rand = Random.Range(0, publicCardList.GetCardList().Count);
			CardSetting element = publicCardList.GetCardList()[rand];

			Card viewCard = view.GetComponent<Card>();
			viewCard.SetCard(element);
			viewCard.DisplayUpdate();
		}
	}


	public void OnClick()
	{
		foreach (GameObject view in viewList)
		{
			rand = Random.Range(0, publicCardList.GetCardList().Count);
			CardSetting element = publicCardList.GetCardList()[rand];

			Card viewCard = view.GetComponent<Card>();
			viewCard.SetCard(element);
			viewCard.DisplayUpdate();
		}
	}

}
