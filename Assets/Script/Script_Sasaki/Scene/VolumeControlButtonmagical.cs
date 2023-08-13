using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControlButtonmagical: MonoBehaviour
{ //音量調節バー表示スクリプト
    //音量調節バーを選択
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
    //ボタンをキー選択させるため、最初に選択されるボタンをGameStartとしてFirstGameStartButtonに入れる
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
    {//音量調節ボタンをクリックすると音量調節バーが表示される
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
    {//×ボタンをクリックすると音量調節バーが非表示にされる
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
        //ボタンをキー選択させるため、音量選択ボタンを選択する
        FirstGameStartButton.Select();
    }
}
