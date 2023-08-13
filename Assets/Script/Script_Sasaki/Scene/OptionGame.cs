using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionGame : MonoBehaviour
{
    //�I�v�V������\��������
    [SerializeField] Image VolumeControlButtonImage;
    [SerializeField] Image OperationButtonButtonImage;
    [SerializeField] Image EndGameButtonButtonImage;
    [SerializeField] Image OptionCloseButtonImage;
    [SerializeField] Image OptionBackgroundImage;
   // [SerializeField] Image BackgroundGray;
    [SerializeField] Button VolumeControlButton;
    [SerializeField] Button OperationButton;
    [SerializeField] Button EndGameButton;
    [SerializeField] Text OptionCloseButtonTextImage;
    [SerializeField] Text VolumeControlButtonButtonText;
    [SerializeField] Text OperationButtonText;
    [SerializeField] Text EndGameButtonButtonText;
    [SerializeField] Text OptionText;
    [SerializeField] Text MouseRevivalText;
    [SerializeField] Text OperationEscText;
    [SerializeField] Button OperationCloseAfterButton;
    private bool EscapeKeyClick;
    //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
    private GameAdministrator gameAdministrator;
    public GameObject Administrator;
    bool isOption = false;
    void Start()
    {
        //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
        gameAdministrator = Administrator.GetComponent<GameAdministrator>();
    }
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
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("�I�v�V�����I��");
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
            OptionCloseButtonTextImage.enabled = true;
                OptionBackgroundImage.enabled = true;
                OptionText.enabled = true;
            MouseRevivalText.enabled = true;
            //BackgroundGray.enabled = true;
            OperationEscText.enabled = false;
            VolumeControlButton.Select();
                // �ړ������Ԗ���
                GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
                Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = false;
                GameObject Camera1 = GameObject.FindGameObjectWithTag("MainCamera");
                Camera1.gameObject.GetComponent<Timecounte>().enabled = false;
                GameObject SiguEffect1 = GameObject.FindGameObjectWithTag("SiguEffect");
                SiguEffect1.gameObject.GetComponent<SiguTimeStoppingParticle>().enabled = false;
                GameObject TimeEffect1 = GameObject.FindGameObjectWithTag("TimeEffect");
                TimeEffect1.gameObject.GetComponent<TimeStoppinEffect>().enabled = false;
                GameObject TimeStopBGM1 = GameObject.FindGameObjectWithTag("TimeStopBGM");
            TimeStopBGM1.gameObject.GetComponent<TimeStoppingBGM>().enabled = false;
            GameObject TimeBGM1 = GameObject.FindGameObjectWithTag("BGM");
            TimeBGM1.gameObject.GetComponent<TimeStopBGM>().enabled = false;
            //�Q�[���X�e�[�^�X�ύX
            gameAdministrator.GameStatus = GameAdministrator.Magical10GameStatus.Option;
            isOption = true;
        }
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Debug.Log("�I�v�V��������");
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
            OptionCloseButtonTextImage.enabled = false;
                OptionBackgroundImage.enabled = false;
                OptionText.enabled = false;
            MouseRevivalText.enabled = false;
            //BackgroundGray.enabled = false;
            OperationEscText.enabled = true;
            // �ړ������Ԗ���
            GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
                Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = true;
                GameObject Camera1 = GameObject.FindGameObjectWithTag("MainCamera");
                Camera1.gameObject.GetComponent<Timecounte>().enabled = true;
            GameObject SiguEffect1 = GameObject.FindGameObjectWithTag("SiguEffect");
            SiguEffect1.gameObject.GetComponent<SiguTimeStoppingParticle>().enabled = true;
            GameObject TimeEffect1 = GameObject.FindGameObjectWithTag("TimeEffect");
            TimeEffect1.gameObject.GetComponent<TimeStoppinEffect>().enabled = true;
            GameObject TimeStopBGM1 = GameObject.FindGameObjectWithTag("TimeStopBGM");
            TimeStopBGM1.gameObject.GetComponent<TimeStoppingBGM>().enabled = true;
            GameObject TimeBGM1 = GameObject.FindGameObjectWithTag("BGM");
            TimeBGM1.gameObject.GetComponent<TimeStopBGM>().enabled = true;
            //�Q�[���X�e�[�^�X�ύX
            //gameAdministrator.GameStatus = GameAdministrator.Magical10GameStatus.Game;
            isOption = false;
        }
            if(isOption == true)
        {
            Debug.Log("�I�v�V�����ύX");
            gameAdministrator.GameStatus = GameAdministrator.Magical10GameStatus.Option;
        } else if(isOption == false)
        {
            
        }
        }

        /*
        if (Input.GetKeyDown(KeyCode.Escape) && VolumeControlButtonImage == true)
        {
            Debug.Log("�I�v�V��������" );
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
        }*/
    
    public void OnOptionCloseClicked()
    {
      
    }
    }
