using UnityEngine;

public class DisplayType : MonoBehaviour
{
	[Header("�\������^�C�v�̑I��"), SerializeField]
	CardType m_cardType;

	public int GiveType()
	{
		return (int)m_cardType;
	}
}
