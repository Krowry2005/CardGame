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

	[Header("1�^�[�����Ƃɑ��₷�J�[�h�̐�"), SerializeField]
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
		//�^�[����؂�ւ��đS���̃^�[��������Ă����烉�E���h�ǉ�
		switch (m_phase)
		{
			case Phase.Start:
				//�J�[�h�𑝂₷
				m_turnUser.GetComponent<User>().IncreaseCard(m_numberOfCard);

				//�����_���[�W�󂯂���Ȃ񂩂���������A������

				break;

			case Phase.Select:
				//���̃J�[�h���g�����̑I��

				break;

			case Phase.Action:
				//�J�[�h�̎��ۂ̏���

				break;

			case Phase.End:
				//�^�[���I�����̏���

				break;
		}
	}

	private void OnMouseDown()
	{
		//�}�E�X�J�[�\���y�уI�u�W�F�N�g�̃X�N���[�����W���擾
		Vector3 objectScreenPoint =
		new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

		//�X�N���[�����W�����[���h���W�ɕϊ�
		Vector3 objectWorldPoint = Camera.main.ScreenToWorldPoint(objectScreenPoint);

		//�I�u�W�F�N�g�̍��W��ύX����
		transform.position = objectWorldPoint;
	}

	public void NextPhase(Phase phase)
	//�w��̃t�F�[�Y�ɐi�߂�
	{
		m_phase = phase;
	}

	public void SetNumberOfCard(int num)
		//�ʂ̂Ƃ����瑝�₷�����Ȃ̂�
	{
		m_numberOfCard = num;
	}
}
