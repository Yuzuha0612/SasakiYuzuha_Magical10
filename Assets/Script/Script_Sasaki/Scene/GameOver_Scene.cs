using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_Scene : MonoBehaviour
{
   // public Text TimeupText;
    //public Text GameOverText;
    void Start()
    {/*
        //�uTIMEUP�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int TIMEUPENABLED = PlayerPrefs.GetInt("TIMEUP");
        if (TIMEUPENABLED == 1)
        {
            //TIMEUP��\��������
            TimeupText.enabled = true;
            GameOverText.enabled = false;
        }
        if (TIMEUPENABLED == 2)
        {
            //GameOver��\��������
            TimeupText.enabled = false;
            GameOverText.enabled = true;
        }*/
    }
    public void OnTitleReloadButtonClicked()
    {
        //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
        FadeManager.Instance.LoadScene("Title", 0.5f);
    }
    public void OnRetryButtonClicked()
    {
       
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int StageReload = PlayerPrefs.GetInt("STAGE");
        //�����uSTAGE�v��0�Ȃ�Stage0�Ɉړ�����
        if (StageReload == 0)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage0", 0.5f);
        }
        //�����uSTAGE�v��1�Ȃ�StagePata_miura�Ɉړ�����
        if (StageReload == 1)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("StagePata_miura", 0.5f);
        }
        //�����uSTAGE�v��2�Ȃ�StageTeku_miura�Ɉړ�����
        if (StageReload == 2)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("StageTeku_miura", 0.5f);
        }
        //�����uSTAGE�v��3�Ȃ�Stage1�Ɉړ�����
        if (StageReload == 3)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage1", 0.5f);
        }
        //�����uSTAGE�v��4�Ȃ�Stage2_Takeda�Ɉړ�����
        if (StageReload == 4)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage2_takeda", 0.5f);
        }
        //�����uSTAGE�v��5�Ȃ�StageEle_miura�Ɉړ�����
        if (StageReload == 5)
        {
            FadeManager.Instance.LoadScene("StageEle_miura", 0.5f);
        }
        //�����uSTAGE�v��4�Ȃ�Stage3_miura�Ɉړ�����
        if (StageReload == 6)
        { //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage3_miura", 0.5f);
        }
        //�����uSTAGE�v��5�Ȃ�StageSabo_miura�Ɉړ�����
        if (StageReload == 7)
        { 
            FadeManager.Instance.LoadScene("StageSabo_miura", 0.5f);
        }
        //�����uSTAGE�v��6�Ȃ�Stage4_miura�Ɉړ�����
        if (StageReload == 8)
        {
            FadeManager.Instance.LoadScene("Stage4_miura", 0.5f);
        }

        //�����uSTAGE�v��7�Ȃ�Stage5_Takeda�Ɉړ�����
        if (StageReload == 9)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage5_takeda", 0.5f);
        }
        //�����uSTAGE�v��8�Ȃ�Stage6_Takeda�Ɉړ�����
        if (StageReload == 10)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage6_takeda", 0.5f);
        }

    }
}
