using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Defense", menuName = "CreateDefenseCard")]
public class DefenseCard : Card
{
	public enum DefenseAttribute
	{
		None,       //–³A‚à‚µ‚­‚Í•¨—
		Fire,       //‰Š
		Wind,       //•—
		Water,      //…
		Soil,       //“y
		Electric,   //“d‹C
		Dark,       //ˆÅ
		Bright,     //Œõ
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