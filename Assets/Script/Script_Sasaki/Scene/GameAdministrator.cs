using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAdministrator : MonoBehaviour
{
    public enum Magical10GameStatus
    {
        Ready,
        Game,
        TimeStop,
        Option,
        Finish
    }
    public Magical10GameStatus GameStatus;
    void Start()
    {
       GameStatus = Magical10GameStatus.Ready;
    }

    void Update()
    {
        switch(GameStatus)
        {

            case Magical10GameStatus.Ready:
                Debug.Log("ゲーム開始");
                break;
            case Magical10GameStatus.Game:
                Debug.Log("ゲーム中");
                break;
            case Magical10GameStatus.TimeStop:
                Debug.Log("時間停止中");
                break;
            case Magical10GameStatus.Option:
                Debug.Log("オプション画面");
                break;
            case Magical10GameStatus.Finish:
                Debug.Log("ゲーム終了");
                break;
        }
    }
}
