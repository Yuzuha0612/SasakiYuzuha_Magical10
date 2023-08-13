using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControlBGM : MonoBehaviour
{//BGMの音量調節用スクリプト
    private AudioSource audioSourceBGMControl;
    void Start()
    {
        audioSourceBGMControl = gameObject.GetComponent<AudioSource>();
        //「BGMVOLUME」というキーで保存されているFloat値を読み込み
        float Bgmvolume = PlayerPrefs.GetFloat("BGMVOLUME");
        // audioSourceSEControl.volumeにいれる
        audioSourceBGMControl.volume = Bgmvolume;
    }

   public void SoundSliderBGMOnvalueChange(float newBGMSliderValue)
    {
        audioSourceBGMControl.volume = newBGMSliderValue;
        //「BGMVOLUME」というキーで、Float値の「newBGMSliderValue」を保存
        PlayerPrefs.SetFloat("BGMVOLUME", newBGMSliderValue);
        PlayerPrefs.Save();
    }
}
