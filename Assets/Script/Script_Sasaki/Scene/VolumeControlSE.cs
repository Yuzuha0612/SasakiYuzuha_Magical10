using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControlSE : MonoBehaviour
{//SE�̉��ʒ��ߗp�X�N���v�g
    private AudioSource audioSourceSEControl;
    void Start()
    {
        audioSourceSEControl = gameObject.GetComponent<AudioSource>();
        //�uSEVOLUME�v�Ƃ����L�[�ŕۑ�����Ă���Float�l��ǂݍ���
        float Sevolume = PlayerPrefs.GetFloat("SEVOLUME");
        // audioSourceSEControl.volume�ɂ����
        audioSourceSEControl.volume = Sevolume;
    }

    public void SoundSliderSEOnvalueChange(float newSESliderValue)
    {
        audioSourceSEControl.volume = newSESliderValue;
        //�uSEVOLUME�v�Ƃ����L�[�ŁAFloat�l�́unewSESliderValue�v��ۑ�
        PlayerPrefs.SetFloat("SEVOLUME", newSESliderValue);
        PlayerPrefs.Save();
    }
}
