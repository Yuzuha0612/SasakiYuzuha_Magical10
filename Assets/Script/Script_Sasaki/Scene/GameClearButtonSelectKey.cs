using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearButtonSelectKey : MonoBehaviour
{//�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������L�[���w������A�Q�[���N���A��ʃo�[�W����
    public Button FirstButton;
    public Button FirstSelectLastStageButton;
    void Start()
    {
        FirstButton.Select();
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int NextStage = PlayerPrefs.GetInt("STAGE");
        //NextStage��1�𑫂�
        NextStage++;
        //�Ō�̃X�e�[�W�̏ꍇ
        //2022�N12��11�������uSTAGE�v��7�Ȃ�{�^�����\���ɂ����A�����{�^����L���ɂ���
        if (NextStage == 7)
        {
            FirstSelectLastStageButton.Select();
        }
    }

}
