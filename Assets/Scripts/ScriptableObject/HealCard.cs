using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Heal", menuName = "CreateHealCard")]
public class HealCard : CardSetting
{
	[SerializeField]
	int heal;

	public int GetHeal()
	{ return heal; }
}