using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OperationSelect : MonoBehaviour
{
    [SerializeField] Image ExplanationImage;
    [SerializeField] Button ExplanationCloseButton;
    [SerializeField] Button ExplanationCloseAndFirstStageButton;
    [SerializeField] Image ExplanationCloseAndFirstStageImage;
    [SerializeField] Image ExplanationImageCloseButton;
    [SerializeField] RawImage ExplanationMovieWalk;
    [SerializeField] RawImage ExplanationMovieJump;
    [SerializeField] Text ExplanationTextWalk;
    [SerializeField] Text ExplanationTextJump;
    //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^����GameStart�Ƃ���FirstGameStartButton�ɓ����
    [SerializeField] Button FirstGameStartButton;
  
    void Start()
    {
    }
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (ExplanationCloseButton.enabled == true))
        {
            //�}�E�X���N���b�N����Ƒ�������摜����\���ɂ����
            ExplanationImage.enabled = false;
            ExplanationCloseButton.enabled = false;
            ExplanationImageCloseButton.enabled = false;
            ExplanationMovieWalk.enabled = false;
            ExplanationMovieJump.enabled = false;
            ExplanationTextWalk.enabled = false;
            ExplanationTextJump.enabled = false;
            //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^�����w������
            FirstGameStartButton.Select();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnOperationExplanationButtonClicked()
    {//��������{�^���������Ƒ�������摜���\�������
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationImageCloseButton.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�~�{�^����I������
        ExplanationCloseButton.Select();
    }

    public void OnOperationExplanationButtonOffClicked()
    {//�~�{�^���������Ƒ�������摜����\���ɂ����
        ExplanationImage.enabled = false;
        ExplanationCloseButton.enabled = false;
        ExplanationImageCloseButton.enabled = false;
        ExplanationMovieWalk.enabled = false;
        ExplanationMovieJump.enabled = false;
        ExplanationTextWalk.enabled = false;
        ExplanationTextJump.enabled = false;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^�����w������
        FirstGameStartButton.Select();
    }

    public void OnOperationExplanationButtonAndFirstStageClicked()
    {//�ŏ�����n�߂�������Ƒ�������摜���\�������
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationCloseAndFirstStageButton.enabled = true;
        ExplanationCloseAndFirstStageImage.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�~�{�^����I������
        ExplanationCloseAndFirstStageButton.Select();
    }
    public void OnOperationExplanationButtonOffAndFirstStageClicked()
    {
        //�~�{�^���������Ƒ�������摜����\���ɂ����
        //�ŏ��̃X�e�[�W�ɐi��
        ExplanationImage.enabled = false;
        ExplanationCloseButton.enabled = false;
        ExplanationCloseAndFirstStageButton.enabled = false;
        ExplanationCloseAndFirstStageImage.enabled = false;
        ExplanationMovieWalk.enabled = false;
        ExplanationMovieJump.enabled = false;
        ExplanationTextWalk.enabled = false;
        ExplanationTextJump.enabled = false;
        //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
       FadeManager.Instance.LoadScene("Stage0",0.5f);
    }
  
    }

