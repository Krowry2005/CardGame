using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "MagicCard", menuName = "CreateMagicCardSetting")]
public class MagicCard : CardSetting
{
	[SerializeField]
	int mp;

	public int GetMP()
	{ return mp; }
}