using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Defense", menuName = "CreateDefenseCard")]
public class DefenseCard : Card
{
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
	DefenseAttribute defenseAttribute;

	[SerializeField]
	int defense;

	public DefenseAttribute GetDefenseAttribute()
	{ return defenseAttribute; }

	public int GetDefense() 
	{ return defense; }
}