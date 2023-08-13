using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControlSE : MonoBehaviour
{//SEの音量調節用スクリプト
    private AudioSource audioSourceSEControl;
    void Start()
    {
        audioSourceSEControl = gameObject.GetComponent<AudioSource>();
        //「SEVOLUME」というキーで保存されているFloat値を読み込み
        float Sevolume = PlayerPrefs.GetFloat("SEVOLUME");
        // audioSourceSEControl.volumeにいれる
        audioSourceSEControl.volume = Sevolume;
    }

    public void SoundSliderSEOnvalueChange(float newSESliderValue)
    {
        audioSourceSEControl.volume = newSESliderValue;
        //「SEVOLUME」というキーで、Float値の「newSESliderValue」を保存
        PlayerPrefs.SetFloat("SEVOLUME", newSESliderValue);
        PlayerPrefs.Save();
    }
}
