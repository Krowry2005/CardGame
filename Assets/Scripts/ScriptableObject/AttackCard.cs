using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Attack", menuName = "CreateAttackCard")]
public class AttackCard : Card
{
	public enum AttackAttribute
	{
		None,		//–³A‚à‚µ‚­‚Í•¨—
		Fire,		//‰Š
		Wind,		//•—
		Water,		//…
		Soil,		//“y
		Electric,	//“d‹C
		Dark,		//ˆÅ
		Bright,		//Œõ
}

	[SerializeField]
	AttackAttribute attackAttribute;

	[SerializeField]
	int attack;

	public AttackAttribute GetAttackAttribute() 
	{ return attackAttribute; }

	public int GetAttack() 
	{ return attack; }
}