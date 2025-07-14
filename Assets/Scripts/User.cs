using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
	string UserName;
	int m_health;
	int m_magicPoint;
	int m_money;

	[Header("HP‚Ì‰Šú’l"),SerializeField]
	static readonly int InitHealth;

	[Header("MP‚Ì‰Šú’l"),SerializeField]
	static readonly int InitMagicPoint;

	[Header("‚¨‹à‚Ì‰Šú’l"),SerializeField]
	static readonly int InitMoney;

	List<CardData> m_cardList = new();

	private void Start()
	{
		ResetStatus();
	}

	public void Damage(int damage)
	{

	}

	public void UseMagic()
	{

	}

	private void ResetStatus()
	{
		m_health = InitHealth;
		m_magicPoint = InitMagicPoint;
		m_money = InitMoney;
	}

}
