using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStopBGM : MonoBehaviour
{ //ゲーム開始判定
    bool isStart = false;
    //AudioSouce初期設定
    AudioSource audioBGMSource;
    //public AudioClip Magical10BGM;
    //時間停止によって音量を下げる前の音量
    public float BGMFirstVolume;
    void Start()
    {
        isStart = false;
        audioBGMSource = GetComponent<AudioSource>();
        //シーン開始時に最初のBGMの音量を取得する
        BGMFirstVolume = audioBGMSource.volume;
        //オプションから設定したBGMを BGMFirstVolumeに入れる？受け取る？
    }


    void Update()
    { //ゲーム開始判定 
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        //移動キーを押している間音量を-0.05ずつ下げる
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            audioBGMSource.volume -= 0.05f;
        } else if(BGMFirstVolume > audioBGMSource.volume) //移動キーを放したら間音量を0.01ずつ上げる
        {
            audioBGMSource.volume += 0.01f;
        }
        else if (BGMFirstVolume < audioBGMSource.volume) //音量が時間停止前の音量を超えないようにする
        {
            audioBGMSource.volume += 0;
        }
        //音量がマイナスにならないようにする
        if (audioBGMSource.volume<0.001f)
        {
            audioBGMSource.volume = 0.001f;
        }

       
       
    }
}
