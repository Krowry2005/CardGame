using UnityEngine;

public enum CardType
{
	All,		//表示のため
	Attack,		//攻撃
	Defense,	//防御
	Heal,
	Magic,		//魔法
	Spirit,		//精霊、悪魔
	Variation,	//カードの変化、手札の変化
	Revival,
	Summon,
	Abnormality,
	Cost,
	Draw,

	Length
}

public enum Target
{
	All,
	Ally,
	Enemy,
	Select,
	Random,
	Me,
}

public class EnumSetting : MonoBehaviour
{
   
}
