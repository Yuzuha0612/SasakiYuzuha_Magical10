using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_GameClear : MonoBehaviour
{
    public bool isGameClear;
    //2022/12/271追加　現在のステージ番号
    public int ClearStageNumber;
    void Start()
    {
        isGameClear = false;
    }
    //ゴールにぶつかったらゴールシーンに移動する
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"Hasrtu"タグが付いている場合
        //TimeCountのGameClear_Timeを実行するため、isGameClearをtrueにする
        if (collision.gameObject.tag == "Hasiru")
        {
            isGameClear = true;
            //2022/12/21追加　ステージ選択クリア状況がセーブされるように変更
            //2022/12/21「STAGECLEAR」というキーで保存されているInt値を読み込み
            int StageClear = PlayerPrefs.GetInt("CLEARSTAGE");
            //既にクリアしているステージよりも現在クリアしたステージ番号が大きい場合はCLEARSTAGEを上書きする
            if (StageClear <= ClearStageNumber)
            {
                //「CLEARSTAGE」というキーで、Int値の「ClearStageNumber」を保存
                PlayerPrefs.SetInt("CLEARSTAGE", ClearStageNumber);
                PlayerPrefs.Save();
            }
        }
    }
    
/*
    private void ClearStageSelect()
    {//2022/12/21追加　ステージ選択クリア状況がセーブされるように変更
     //2022/12/21「STAGECLEAR」というキーで保存されているInt値を読み込み
     int StageClear = PlayerPrefs.GetInt("CLEARSTAGE");
        //既にクリアしているステージよりも現在クリアしたステージ番号が大きい場合はCLEARSTAGEを上書きする
        if (StageClear <= ClearStageNumber)
        {
            //「CLEARSTAGE」というキーで、Int値の「ClearStageNumber」を保存
            PlayerPrefs.SetInt("CLEARSTAGE", ClearStageNumber);
            PlayerPrefs.Save();
        }
    }*/
}
