using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStar : MonoBehaviour
{//クリア時の星の数を保存するスクリプト
    //TimeStar01 星一つの時の秒数　
    public int TimeStar01;
    public int TimeStar03;
    void Start()
    {
        //「TIMESTAR1」というキーで、Int値の「TimeStar01」を保存
        PlayerPrefs.SetInt("TIMESTAR1", TimeStar01);
        PlayerPrefs.Save();
        //「TIMESTAR3」というキーで、Int値の「TimeStar03」を保存
        PlayerPrefs.SetInt("TIMESTAR3", TimeStar03);
        PlayerPrefs.Save();
    }
}
