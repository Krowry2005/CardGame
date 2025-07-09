using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "HealAndAttack", menuName = "CreateHealAndAttackCard")]
public class HealAndAttckCard : CardSetting
{
	[SerializeField]
	int heal;

	[SerializeField]
	int attck;

	public int GetHeal()
	{ return heal; }

	public int GetAttck() 
	{ return attck; }
}