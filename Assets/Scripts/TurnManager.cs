using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
	int m_round;
	User m_turnUser;
	List<User> userList = new();
	List<User> alertUserList = new();

	private void Start()
	{
		m_round = 0;
	}


	private void Update()
	{
		//ターンを切り替えて全員のターンが回ってきたらラウンド追加
	}

	//オブジェクトをクリックしてドラッグ状態にある間呼び出される関数（Unityのマウスイベント）
	void OnMouseDrag()
	{
		//マウスカーソル及びオブジェクトのスクリーン座標を取得
		Vector3 objectScreenPoint =
			new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

		//スクリーン座標をワールド座標に変換
		Vector3 objectWorldPoint = Camera.main.ScreenToWorldPoint(objectScreenPoint);

		//オブジェクトの座標を変更する
		transform.position = objectWorldPoint;
	}
}
