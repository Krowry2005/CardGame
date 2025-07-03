using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Both", menuName = "CreateBothCard")]
public class BothCard : Card
{
	public enum AttackAttribute
	{
		None,       //���A�������͕���
		Fire,       //��
		Wind,       //��
		Water,      //��
		Soil,       //�y
		Electric,   //�d�C
		Dark,       //��
		Bright,     //��
	}
	public enum DefenseAttribute
	{
		None,       //���A�������͕���
		Fire,       //��
		Wind,       //��
		Water,      //��
		Soil,       //�y
		Electric,   //�d�C
		Dark,       //��
		Bright,     //��
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
