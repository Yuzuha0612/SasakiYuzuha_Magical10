using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_GameClear : MonoBehaviour
{
    public bool isGameClear;
    //2022/12/271�ǉ��@���݂̃X�e�[�W�ԍ�
    public int ClearStageNumber;
    void Start()
    {
        isGameClear = false;
    }
    //�S�[���ɂԂ�������S�[���V�[���Ɉړ�����
    private void OnCollisionEnter(Collision collision)
    {
        // �������������"Hasrtu"�^�O���t���Ă���ꍇ
        //TimeCount��GameClear_Time�����s���邽�߁AisGameClear��true�ɂ���
        if (collision.gameObject.tag == "Hasiru")
        {
            isGameClear = true;
            //2022/12/21�ǉ��@�X�e�[�W�I���N���A�󋵂��Z�[�u�����悤�ɕύX
            //2022/12/21�uSTAGECLEAR�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
            int StageClear = PlayerPrefs.GetInt("CLEARSTAGE");
            //���ɃN���A���Ă���X�e�[�W�������݃N���A�����X�e�[�W�ԍ����傫���ꍇ��CLEARSTAGE���㏑������
            if (StageClear <= ClearStageNumber)
            {
                //�uCLEARSTAGE�v�Ƃ����L�[�ŁAInt�l�́uClearStageNumber�v��ۑ�
                PlayerPrefs.SetInt("CLEARSTAGE", ClearStageNumber);
                PlayerPrefs.Save();
            }
        }
    }
    
/*
    private void ClearStageSelect()
    {//2022/12/21�ǉ��@�X�e�[�W�I���N���A�󋵂��Z�[�u�����悤�ɕύX
     //2022/12/21�uSTAGECLEAR�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
     int StageClear = PlayerPrefs.GetInt("CLEARSTAGE");
        //���ɃN���A���Ă���X�e�[�W�������݃N���A�����X�e�[�W�ԍ����傫���ꍇ��CLEARSTAGE���㏑������
        if (StageClear <= ClearStageNumber)
        {
            //�uCLEARSTAGE�v�Ƃ����L�[�ŁAInt�l�́uClearStageNumber�v��ۑ�
            PlayerPrefs.SetInt("CLEARSTAGE", ClearStageNumber);
            PlayerPrefs.Save();
        }
    }*/
}
