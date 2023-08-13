using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControlVolumevalue : MonoBehaviour
{//BGMVolume, SEVolumeはBGMとSEのテキスト
    public Text BGMVolume;
    public Text SEVolume;
    //BGMVolumeSlider, SEVolumeSliderはBGMとSEのスライダー
    public Slider BGMVolumeSlider;
    public Slider SEVolumeSlider;
    // BGMVolumeFloat, SEVolumeFloatはBGMとSEの音量
    public float BGMVolumeFloat;
    public float SEVolumeFloat;
    void Start()
    {
        
    }

    void Update()
    {   //音量取得
        BGMVolumeFloat = BGMVolumeSlider.value;
        SEVolumeFloat = SEVolumeSlider.value;
        //BGMの音量を表示させる
       BGMVolume.text = "BGM　"+BGMVolumeFloat.ToString("0.0")  ; //fixapdate
        //SEの音量を表示させる
        SEVolume.text = "SE　" + SEVolumeFloat.ToString("0.0"); //fixapdate
    }
}
