using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMagical10 : MonoBehaviour
{
    //オプションを表示させる
    [SerializeField] Image VolumeControlButtonImage;
    [SerializeField] Image OperationButtonButtonImage;
    [SerializeField] Image EndGameButtonButtonImage;
    [SerializeField] Image OptionCloseButtonImage;
    [SerializeField] Image OptionBackgroundImage;
    [SerializeField] Button VolumeControlButton;
    [SerializeField] Button OperationButton;
    [SerializeField] Button EndGameButton;
    [SerializeField] Button OptionCloseButton;
    [SerializeField] Text VolumeControlButtonButtonText;
    [SerializeField] Text OperationButtonText;
    [SerializeField] Text EndGameButtonButtonText;
    [SerializeField] Text OptionText;
    [SerializeField] Text MouseF2Test;
    [SerializeField] Button OperationCloseAfterButton;
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (VolumeControlButton.enabled == true))
        {
            VolumeControlButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnOptionClicked()
    {
        VolumeControlButtonImage.enabled = true;
        OperationButtonButtonImage.enabled = true;
         EndGameButtonButtonImage.enabled = true;
        VolumeControlButton.enabled = true;
     OperationButton.enabled = true;
        EndGameButton.enabled = true;
        VolumeControlButtonButtonText.enabled = true;
        OperationButtonText.enabled = true;
        EndGameButtonButtonText.enabled = true;
        OptionCloseButtonImage.enabled = true;
        OptionCloseButton.enabled = true;
        OptionBackgroundImage.enabled = true;
        OptionText.enabled = true;
        MouseF2Test.enabled = true;
        VolumeControlButton.Select();
    }
     public void OnOptionCloseClicked()
    {
        VolumeControlButtonImage.enabled = false;
        OperationButtonButtonImage.enabled = false;
        EndGameButtonButtonImage.enabled = false;
        VolumeControlButton.enabled = false;
        OperationButton.enabled = false;
        EndGameButton.enabled = false;
        VolumeControlButtonButtonText.enabled = false;
        OperationButtonText.enabled = false;
        EndGameButtonButtonText.enabled = false;
        OptionCloseButtonImage.enabled = false;
        OptionCloseButton.enabled = false;
        OptionBackgroundImage.enabled = false;
        OptionText.enabled = false;
        MouseF2Test.enabled = false;
        OperationCloseAfterButton.Select();
    }
}
