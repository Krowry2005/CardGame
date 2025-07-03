using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Attack", menuName = "CreateAttackCard")]
public class AttackCard : Card
{
	public enum AttackAttribute
	{
		None,		//���A�������͕���
		Fire,		//��
		Wind,		//��
		Water,		//��
		Soil,		//�y
		Electric,	//�d�C
		Dark,		//��
		Bright,		//��
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