using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Scene : MonoBehaviour
{
    [SerializeField] Image StageSelectImage;
    [SerializeField] Button StageSelectButton;
    [SerializeField] Text StageSelectText;
    [SerializeField] Button FirstStageButton;
    [SerializeField] Image FirstStageImage;
    [SerializeField] Text FirstStageText;
    [SerializeField] Button ReturnButton;
    [SerializeField] Image ReturnImage;
    [SerializeField] Text ReturnText;
    //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^������GameStart�Ƃ���FirstGameStartButton�ɓ����
    [SerializeField] Button FirstGameStartButton;
  


    void Start()
    {
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int StageReload = PlayerPrefs.GetInt("CLEARSTAGE");
        //�����uSTAGE�v��0�ȏ�Ȃ玎���I���{�^���𔒐F�ɂ���
        if (StageReload  >= 0 )
        {
            StageSelectImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
      
    }

    void Update()
    {//2023/1/7�ǉ��}�E�X���͂���Ǝ����J�n��I��������
        if ((Input.GetMouseButtonDown(0)) &&(StageSelectButton.enabled==true))
        {
            FirstStageButton.Select();
            //FirstGameStartButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if  (Input.GetMouseButtonDown(0)&& (StageSelectButton.enabled == false))
            {
            FirstGameStartButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void OnStartButtonClicked()
    {//�����J�n�{�^���������ƍŏ�����n�߂�{�^���ƃX�e�[�W�I���{�^���A�߂�{�^�����\�������
        StageSelectImage.enabled = true;
        StageSelectButton.enabled = true;
        StageSelectText.enabled = true;
        FirstStageButton.enabled = true;
        FirstStageImage.enabled = true;
        FirstStageText.enabled = true;
        ReturnButton.enabled = true;
        ReturnImage.enabled = true;
        ReturnText.enabled = true;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^�����w������
        FirstStageButton.Select();
    }
    public void OnReturnButtonClicked()
    {//�߂�{�^���������ƍŏ�����n�߂�{�^���ƃX�e�[�W�I���{�^���A�߂�{�^������\���ɂ����
        StageSelectImage.enabled = false;
        StageSelectButton.enabled = false;
        StageSelectText.enabled = false;
        FirstStageButton.enabled = false;
        FirstStageImage.enabled = false;
        FirstStageText.enabled = false;
        ReturnButton.enabled = false;
        ReturnImage.enabled = false;
        ReturnText.enabled = false;
        FirstGameStartButton.Select();
    }
    public void OnStageSelectButtonClicked()
    {
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int StageReload = PlayerPrefs.GetInt("CLEARSTAGE");
        //�����uCLEARSTAGE�v��0�ȏ�Ȃ玎���I����ʂɈڍs
        if (StageReload >= 0)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("StageSelect", 0.5f);
        }
    }
}
