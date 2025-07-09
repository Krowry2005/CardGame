using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "AttackCard", menuName = "CreateAttackCardSetting")]
public class AttackCard : CardSetting
{
	[SerializeField]
	User.Attribute attackAttribute;

	[SerializeField]
	int attack;

	public User.Attribute GetAttribute() 
	{ return attackAttribute; }

	public int GetAttack() 
	{ return attack; }
}