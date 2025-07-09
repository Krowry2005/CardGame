using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "BothCard", menuName = "CreateBothCardSetting")]
public class BothCard : CardSetting
{
	[SerializeField]
	User.Attribute attackAttribute;

	[SerializeField]
	User.Attribute defenseAttribute;

	[SerializeField]
	int attack;

	[SerializeField]
	int defense;

	public User.Attribute GetAttackAttribute()
	{ return attackAttribute; }
	public User.Attribute GetDefenseAttribute()
	{ return defenseAttribute; }

	public int GetAttack()
	{ return attack; }

	public int GetDefense()
	{ return defense; }
}
