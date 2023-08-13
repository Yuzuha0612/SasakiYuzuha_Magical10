using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStoppingBGM : MonoBehaviour
{//ゲーム開始判定
    bool isStart = false;
    //AudioSouce初期設定
    AudioSource audioTimeStoppingBGMSource;
    //時間停止によって音量を上げる前の音量
    public float BGMFirstVolume;
    //2023/2/22追加　ゲームマネージャー取得
    private GameAdministrator gameAdministrator;
    public GameObject Administrator;
    void Start()
    {
        isStart = false;
        audioTimeStoppingBGMSource = GetComponent<AudioSource>();
        //シーン開始時に最初のBGMの音量を取得する
        BGMFirstVolume = audioTimeStoppingBGMSource.volume;
        //2023/2/22追加　ゲームマネージャー取得
        gameAdministrator = Administrator.GetComponent<GameAdministrator>();
    }


    void Update()
    { //ゲーム開始判定 
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        //移動キーを押している間音量を0.05ずつ上げる
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            audioTimeStoppingBGMSource.volume += 0.05f;
        }
        else if (BGMFirstVolume < audioTimeStoppingBGMSource.volume) //移動キーを放したら間音量を0.1ずつ下げる
        {
            audioTimeStoppingBGMSource.volume -= 0.1f;
        }
        else if (BGMFirstVolume > audioTimeStoppingBGMSource.volume) //音量が時間停止前の音量を超えないようにする
        {
            audioTimeStoppingBGMSource.volume += 0;
        }
        //音量がマイナスにならないようにする
        if (audioTimeStoppingBGMSource.volume < 0.001f)
        {
            audioTimeStoppingBGMSource.volume = 0.001f;
        }
        //音量がマイナスにならないようにする
        if (audioTimeStoppingBGMSource.volume > 1.0f)
        {
            audioTimeStoppingBGMSource.volume = 1.0f;
        }



    }
}
