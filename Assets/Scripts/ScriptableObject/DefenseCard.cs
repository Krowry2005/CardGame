using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "DefenseCard", menuName = "CreateDefenseCardSetting")]
public class DefenseCard : CardSetting
{
	[SerializeField]
	User.Attribute defenseAttribute;

	[SerializeField]
	int defense;

	public User.Attribute GetAttribute()
	{ return defenseAttribute; }

	public int GetDefense() 
	{ return defense; }
}