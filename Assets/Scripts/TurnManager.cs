using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
	public enum Phase
	{
		Start,
		Select,
		Action,
		End,
	}

	[Header("1ターンごとに増やすカードの数"), SerializeField]
	int m_numberOfCard = 1;

	int m_round;
	Phase m_phase;
	User m_turnUser;
	List<User> userList = new();
	List<User> alertUserList = new();

	private void Start()
	{
		m_phase = Phase.Start;
	}


	private void Update()
	{
		//ターンを切り替えて全員のターンが回ってきたらラウンド追加
		switch (m_phase)
		{
			case Phase.Start:
				//カードを増やす
				m_turnUser.GetComponent<User>().IncreaseCard(m_numberOfCard);

				//持続ダメージ受けたりなんかおこったり、今後作る

				break;

			case Phase.Select:
				//何のカードを使うかの選択

				break;

			case Phase.Action:
				//カードの実際の処理

				break;

			case Phase.End:
				//ターン終了時の処理

				break;
		}
	}

	public void NextPhase(Phase phase)
	//指定のフェーズに進める
	{
		m_phase = phase;
	}

	public void SetNumberOfCard(int num)
		//別のとこから増やすかもなので
	{
		m_numberOfCard = num;
	}
}
