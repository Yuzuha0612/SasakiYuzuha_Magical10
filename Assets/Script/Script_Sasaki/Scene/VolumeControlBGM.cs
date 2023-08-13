using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControlBGM : MonoBehaviour
{//BGM�̉��ʒ��ߗp�X�N���v�g
    private AudioSource audioSourceBGMControl;
    void Start()
    {
        audioSourceBGMControl = gameObject.GetComponent<AudioSource>();
        //�uBGMVOLUME�v�Ƃ����L�[�ŕۑ�����Ă���Float�l��ǂݍ���
        float Bgmvolume = PlayerPrefs.GetFloat("BGMVOLUME");
        // audioSourceSEControl.volume�ɂ����
        audioSourceBGMControl.volume = Bgmvolume;
    }

   public void SoundSliderBGMOnvalueChange(float newBGMSliderValue)
    {
        audioSourceBGMControl.volume = newBGMSliderValue;
        //�uBGMVOLUME�v�Ƃ����L�[�ŁAFloat�l�́unewBGMSliderValue�v��ۑ�
        PlayerPrefs.SetFloat("BGMVOLUME", newBGMSliderValue);
        PlayerPrefs.Save();
    }
}
