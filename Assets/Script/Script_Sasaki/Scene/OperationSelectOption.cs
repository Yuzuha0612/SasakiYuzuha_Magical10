using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OperationSelectOption : MonoBehaviour
{
    [SerializeField] Image ExplanationImage;
    [SerializeField] Button ExplanationCloseButton;
    [SerializeField] Image ExplanationImageCloseButton;
    [SerializeField] RawImage ExplanationMovieWalk;
    [SerializeField] RawImage ExplanationMovieJump;
    [SerializeField] Text ExplanationTextWalk;
    [SerializeField] Text ExplanationTextJump;
    //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^����GameStart�Ƃ���FirstGameStartButton�ɓ����
    [SerializeField] Button FirstGameStartButton;
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
}

