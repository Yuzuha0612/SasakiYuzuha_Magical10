using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStoppingBGM : MonoBehaviour
{//�Q�[���J�n����
    bool isStart = false;
    //AudioSouce�����ݒ�
    AudioSource audioTimeStoppingBGMSource;
    //���Ԓ�~�ɂ���ĉ��ʂ��グ��O�̉���
    public float BGMFirstVolume;
    //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
    private GameAdministrator gameAdministrator;
    public GameObject Administrator;
    void Start()
    {
        isStart = false;
        audioTimeStoppingBGMSource = GetComponent<AudioSource>();
        //�V�[���J�n���ɍŏ���BGM�̉��ʂ��擾����
        BGMFirstVolume = audioTimeStoppingBGMSource.volume;
        //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
        gameAdministrator = Administrator.GetComponent<GameAdministrator>();
    }


    void Update()
    { //�Q�[���J�n���� 
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        //�ړ��L�[�������Ă���ԉ��ʂ�0.05���グ��
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            audioTimeStoppingBGMSource.volume += 0.05f;
        }
        else if (BGMFirstVolume < audioTimeStoppingBGMSource.volume) //�ړ��L�[���������ԉ��ʂ�0.1��������
        {
            audioTimeStoppingBGMSource.volume -= 0.1f;
        }
        else if (BGMFirstVolume > audioTimeStoppingBGMSource.volume) //���ʂ����Ԓ�~�O�̉��ʂ𒴂��Ȃ��悤�ɂ���
        {
            audioTimeStoppingBGMSource.volume += 0;
        }
        //���ʂ��}�C�i�X�ɂȂ�Ȃ��悤�ɂ���
        if (audioTimeStoppingBGMSource.volume < 0.001f)
        {
            audioTimeStoppingBGMSource.volume = 0.001f;
        }
        //���ʂ��}�C�i�X�ɂȂ�Ȃ��悤�ɂ���
        if (audioTimeStoppingBGMSource.volume > 1.0f)
        {
            audioTimeStoppingBGMSource.volume = 1.0f;
        }



    }
}
