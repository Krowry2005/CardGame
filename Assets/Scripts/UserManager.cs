using TMPro;
using UnityEngine;

public class UserManager : MonoBehaviour
{
	[Header("�v���C���[�l��")]
	int m_userAmount;

	[Header("CPU�̐�")]
	int m_cpuAmount;

	[SerializeField]
	TextMeshProUGUI m_userAmountText;

	[SerializeField]
	TextMeshProUGUI m_cpuAmountText;

	public void UserAmountText()
	{
		m_userAmountText.text = "�@�l���@�F�@" + m_userAmount;
	}

	public void CPUAmountText()
	{
		m_cpuAmountText.text = "�@CPU�̐� �F " + m_cpuAmount; 
	}

	public void UserIncrease(bool increase)
	{
		//���[�U�[�𑝂₵���茸�炵���肷��i�{�^���ŌĂяo���j
		m_userAmount += increase ? m_userAmount >= 10 ? 0 : 1 : m_userAmount <= 1 ? 0 : -1;
		if (m_userAmount + m_cpuAmount > 10)
		{
			m_cpuAmount--;
			CPUAmountText();
		}
		if (m_userAmount + m_cpuAmount < 2)
		{
			m_cpuAmount++;
			CPUAmountText();
		}
	}

	public void CPUIncrease(bool increase)
	{
		//CPU�̑���
		m_cpuAmount += increase ? m_cpuAmount >= 9 ? 0 : 1 : m_cpuAmount <= 1 ? 0 : -1;
		if(m_userAmount + m_cpuAmount > 10)
		{
			m_userAmount--;
			UserAmountText();
		}
	}

	public int GetUserAmount()
	{ return m_userAmount; }
}
