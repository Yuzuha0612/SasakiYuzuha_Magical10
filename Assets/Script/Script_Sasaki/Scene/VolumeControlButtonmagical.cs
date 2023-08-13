using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControlButtonmagical: MonoBehaviour
{ //���ʒ��߃o�[�\���X�N���v�g
    //���ʒ��߃o�[��I��
    [SerializeField] Image VolumeControlBackgroundImage;
    [SerializeField] Image VolumeControlImageCloseButton;
    [SerializeField] Button VolumeControlCloseButton;
    [SerializeField] Text VolumeControlBGMText;
    [SerializeField] Text VolumeControlSEText;
    [SerializeField] Slider VolumeControlBGMSlider;
    [SerializeField] Slider VolumeControlSESlider;
    [SerializeField] Image VolumeControlBackgroundBGMImage;
    [SerializeField] Image VolumeControlBackgroundSEImage;
    [SerializeField] Image VolumeControlFillBGMImage;
    [SerializeField] Image VolumeControlFillSEImage;
    [SerializeField] Image VolumeControlHandleBGMImage;
    [SerializeField] Image VolumeControlHandleSEImage;
    //�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^����GameStart�Ƃ���FirstGameStartButton�ɓ����
    [SerializeField] Button FirstGameStartButton;

     void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (VolumeControlCloseButton.enabled == true))
        {
            VolumeControlCloseButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnOperationVolumeControlClicked()
    {//���ʒ��߃{�^�����N���b�N����Ɖ��ʒ��߃o�[���\�������
        VolumeControlBackgroundImage.enabled = true;
        VolumeControlImageCloseButton.enabled = true;
        VolumeControlCloseButton.enabled = true;
       VolumeControlBGMText.enabled = true;
       VolumeControlSEText.enabled = true;
        VolumeControlBGMSlider.enabled = true;
      VolumeControlSESlider.enabled = true;
       VolumeControlBackgroundBGMImage.enabled = true;
        VolumeControlBackgroundSEImage.enabled = true;
       VolumeControlFillBGMImage.enabled = true;
       VolumeControlFillSEImage.enabled = true;
        VolumeControlHandleBGMImage.enabled = true;
       VolumeControlHandleSEImage.enabled = true;
        VolumeControlBGMSlider.Select();
    }
    public void OnOperationVolumeControlCloseClicked()
    {//�~�{�^�����N���b�N����Ɖ��ʒ��߃o�[����\���ɂ����
        VolumeControlBackgroundImage.enabled = false;
        VolumeControlImageCloseButton.enabled = false;
        VolumeControlCloseButton.enabled = false;
        VolumeControlBGMText.enabled = false;
        VolumeControlSEText.enabled = false;
        VolumeControlBGMSlider.enabled = false;
        VolumeControlSESlider.enabled = false;
        VolumeControlBackgroundBGMImage.enabled = false;
        VolumeControlBackgroundSEImage.enabled = false;
        VolumeControlFillBGMImage.enabled = false;
        VolumeControlFillSEImage.enabled = false;
        VolumeControlHandleBGMImage.enabled = false;
        VolumeControlHandleSEImage.enabled = false;
        //�{�^�����L�[�I�������邽�߁A���ʑI���{�^����I������
        FirstGameStartButton.Select();
    }
}
