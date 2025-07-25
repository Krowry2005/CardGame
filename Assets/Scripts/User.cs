using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
	string UserName;
	int m_health;
	int m_magicPoint;
	int m_money;

	[Header("HPの初期値"),SerializeField]
	static readonly int InitHealth;

	[Header("MPの初期値"),SerializeField]
	static readonly int InitMagicPoint;

	[Header("お金の初期値"),SerializeField]
	static readonly int InitMoney;

	List<CardData> m_cardList = new();

	private void Start()
	{
		ResetStatus();
	}

	public void Damage(int damage)
	{

	}

	public void Heal(int heal)
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
