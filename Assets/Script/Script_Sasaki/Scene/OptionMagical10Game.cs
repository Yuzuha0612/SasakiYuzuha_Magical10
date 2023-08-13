using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMagical10Game : MonoBehaviour
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
    [SerializeField] Button OperationCloseAfterButton;

    void Update()
    {//エスケープキーでオプション表示
        if (Input.GetKeyDown(KeyCode.Escape))
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
            VolumeControlButton.Select();
        }
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
        OperationCloseAfterButton.Select();
    }
}
