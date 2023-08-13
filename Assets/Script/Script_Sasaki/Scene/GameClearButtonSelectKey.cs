using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearButtonSelectKey : MonoBehaviour
{//ボタンをキー選択させるため、最初に選択されるキーを指示する、ゲームクリア画面バージョン
    public Button FirstButton;
    public Button FirstSelectLastStageButton;
    void Start()
    {
        FirstButton.Select();
        //「STAGE」というキーで保存されているInt値を読み込み
        int NextStage = PlayerPrefs.GetInt("STAGE");
        //NextStageに1を足す
        NextStage++;
        //最後のステージの場合
        //2022年12月11日もし「STAGE」が7ならボタンを非表示にさせ、透明ボタンを有効にする
        if (NextStage == 7)
        {
            FirstSelectLastStageButton.Select();
        }
    }

}
