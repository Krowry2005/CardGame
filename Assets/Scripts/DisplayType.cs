using UnityEngine;

public class DisplayType : MonoBehaviour
{
	[Header("表示するタイプの選択"), SerializeField]
	CardType m_cardType;

	public int GiveType()
	{
		return (int)m_cardType;
	}
}
