using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Both", menuName = "CreateBothCard")]
public class BothCard : Card
{
	public enum AttackAttribute
	{
		None,       //無、もしくは物理
		Fire,       //炎
		Wind,       //風
		Water,      //水
		Soil,       //土
		Electric,   //電気
		Dark,       //闇
		Bright,     //光
	}
	public enum DefenseAttribute
	{
		None,       //無、もしくは物理
		Fire,       //炎
		Wind,       //風
		Water,      //水
		Soil,       //土
		Electric,   //電気
		Dark,       //闇
		Bright,     //光
	}

	[SerializeField]
	AttackAttribute attackAttribute;

	[SerializeField]
	DefenseAttribute defenseAttribute;

	[SerializeField]
	int attack;

	[SerializeField]
	int defense;

	public AttackAttribute GetAttackAttribute()
	{ return attackAttribute; }
	public DefenseAttribute GetDefenseAttribute()
	{ return defenseAttribute; }

	public int GetAttack()
	{ return attack; }

	public int GetDefense()
	{ return defense; }
}
