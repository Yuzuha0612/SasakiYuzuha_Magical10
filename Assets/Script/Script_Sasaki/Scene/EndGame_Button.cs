using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame_Button : MonoBehaviour
{
    //�w�i
    [SerializeField] Image EndGameWarningImage;
    //�������{�^��
    [SerializeField] Button EndGameWarningCloseButton;
    [SerializeField] Image EndGameWarningCloseImage;
    [SerializeField] Text EndGameWarningCloseText;
    [SerializeField] Text EndGameWarningCloseSelectText;
    //�Q�[���I�����܂����e�L�X�g
    [SerializeField] Text EndGameWarningText;
    //�͂��{�^��
    [SerializeField] Button EndGameButton;
    [SerializeField] Image EndGameImage;
    [SerializeField] Text EndGameText;
    //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^����GameStart�Ƃ���FirstGameStartButton�ɓ����
    [SerializeField] Button FirstGameStartButton;
    //
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (EndGameWarningCloseButton.enabled == true))
        {
            EndGameWarningCloseButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnEndGameFirstButtonClicked()
    {//�ŏ��ɃQ�[���I���{�^���������ƃQ�[���I���x����ʂ��\�������
        EndGameWarningImage.enabled = true;
        EndGameWarningText.enabled = true;
        EndGameWarningCloseButton.enabled = true;
        EndGameWarningCloseImage.enabled = true;
        EndGameWarningCloseText.enabled = true;
        EndGameButton.enabled = true;
        EndGameImage.enabled = true;
        EndGameText.enabled = true;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�������{�^����I������
        EndGameWarningCloseButton.Select();
    }

    public void OnEndGameSecondButtonOffClicked()
    {//�͂��������ƃQ�[�����I������
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
    public void OnEndGameWarningButtonOffClicked()
    {//�������������ƃX�e�[�W�I����ʂɖ߂�
        EndGameWarningImage.enabled = false;
        EndGameWarningText.enabled = false;
        EndGameWarningCloseButton.enabled = false;
        EndGameWarningCloseImage.enabled = false;
        EndGameWarningCloseText.enabled = false;
        EndGameButton.enabled = false;
        EndGameImage.enabled = false;
        EndGameText.enabled = false; 
        EndGameWarningCloseSelectText.enabled = false;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�����J�n�{�^����I������
        FirstGameStartButton.Select();
    }
}
