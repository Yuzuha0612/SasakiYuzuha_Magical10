using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControlVolumevalue : MonoBehaviour
{//BGMVolume, SEVolume��BGM��SE�̃e�L�X�g
    public Text BGMVolume;
    public Text SEVolume;
    //BGMVolumeSlider, SEVolumeSlider��BGM��SE�̃X���C�_�[
    public Slider BGMVolumeSlider;
    public Slider SEVolumeSlider;
    // BGMVolumeFloat, SEVolumeFloat��BGM��SE�̉���
    public float BGMVolumeFloat;
    public float SEVolumeFloat;
    void Start()
    {
        
    }

    void Update()
    {   //���ʎ擾
        BGMVolumeFloat = BGMVolumeSlider.value;
        SEVolumeFloat = SEVolumeSlider.value;
        //BGM�̉��ʂ�\��������
       BGMVolume.text = "BGM�@"+BGMVolumeFloat.ToString("0.0")  ; //fixapdate
        //SE�̉��ʂ�\��������
        SEVolume.text = "SE�@" + SEVolumeFloat.ToString("0.0"); //fixapdate
    }
}
