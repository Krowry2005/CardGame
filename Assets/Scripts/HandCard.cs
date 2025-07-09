using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HandCard : MonoBehaviour
{
	[Header("���ʂ̃J�[�h���X�g"), SerializeField]
	PublicCardList PublicCardList;

	public List<CardSetting> GetPublicCardList()
	//��{�̃J�[�h���X�g���������Ăق����Ȃ��̂ŃJ�[�h�𑝂₷�Ƃ��ɌĂ΂�邱���̂݁A�p�u���b�N�J�[�h���X�g������
	//���݂��݂����Ȃ��Ƃ��Ă邯�ǂق��Ő�ΐG���Ăق����Ȃ�����
	{
		return PublicCardList.GetCardList();
	}

	public List<CardSetting> DistributeCard(List<CardSetting> cardList, int handsNumber)
	//�J�[�h���X�g�̒������D�ɉ�����J�[�h��I�Ԋ֐�(��{�̃J�[�h���X�g�A���₷����)
	{
		List<CardSetting> cards = new();
		for(int i = 0; i < handsNumber; i++)
		{
			//�����_���Ŏ�D�����߁A�������D�ɉ�����
			int rand = Random.Range(1, (cardList.Count + 1));

			//�����P�ɂ����蓾�Ă͂����Ȃ��b�����ǂ��A������ID���Ԃ肪�������Ƃ��A��ȏ�A���Ă��邩��AddRange
			cards.AddRange(cardList.Where(card => card.GetID() == rand));
		}
		return cards;
	}
}
