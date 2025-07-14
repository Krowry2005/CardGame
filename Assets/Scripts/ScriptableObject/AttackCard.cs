using System;
using UnityEngine;

[CreateAssetMenu(fileName = "AttackCard", menuName = "ScriptableObject/CreateAttackCard")]
[Serializable]
public class AttackCard : CardData
{
	[SerializeField]
	int m_attack;

	public int GetAttack()
	{return m_attack;}
}