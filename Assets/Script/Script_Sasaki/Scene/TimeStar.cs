using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStar : MonoBehaviour
{//�N���A���̐��̐���ۑ�����X�N���v�g
    //TimeStar01 ����̎��̕b���@
    public int TimeStar01;
    public int TimeStar03;
    void Start()
    {
        //�uTIMESTAR1�v�Ƃ����L�[�ŁAInt�l�́uTimeStar01�v��ۑ�
        PlayerPrefs.SetInt("TIMESTAR1", TimeStar01);
        PlayerPrefs.Save();
        //�uTIMESTAR3�v�Ƃ����L�[�ŁAInt�l�́uTimeStar03�v��ۑ�
        PlayerPrefs.SetInt("TIMESTAR3", TimeStar03);
        PlayerPrefs.Save();
    }
}
