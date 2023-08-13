using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStopBGM : MonoBehaviour
{ //�Q�[���J�n����
    bool isStart = false;
    //AudioSouce�����ݒ�
    AudioSource audioBGMSource;
    //public AudioClip Magical10BGM;
    //���Ԓ�~�ɂ���ĉ��ʂ�������O�̉���
    public float BGMFirstVolume;
    void Start()
    {
        isStart = false;
        audioBGMSource = GetComponent<AudioSource>();
        //�V�[���J�n���ɍŏ���BGM�̉��ʂ��擾����
        BGMFirstVolume = audioBGMSource.volume;
        //�I�v�V��������ݒ肵��BGM�� BGMFirstVolume�ɓ����H�󂯎��H
    }


    void Update()
    { //�Q�[���J�n���� 
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        //�ړ��L�[�������Ă���ԉ��ʂ�-0.05��������
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            audioBGMSource.volume -= 0.05f;
        } else if(BGMFirstVolume > audioBGMSource.volume) //�ړ��L�[���������ԉ��ʂ�0.01���グ��
        {
            audioBGMSource.volume += 0.01f;
        }
        else if (BGMFirstVolume < audioBGMSource.volume) //���ʂ����Ԓ�~�O�̉��ʂ𒴂��Ȃ��悤�ɂ���
        {
            audioBGMSource.volume += 0;
        }
        //���ʂ��}�C�i�X�ɂȂ�Ȃ��悤�ɂ���
        if (audioBGMSource.volume<0.001f)
        {
            audioBGMSource.volume = 0.001f;
        }

       
       
    }
}
