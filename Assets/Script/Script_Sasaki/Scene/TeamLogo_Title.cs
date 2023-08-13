using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeamLogo_Title : MonoBehaviour
{//チームロゴを表示させてタイトルに移動するスクリプトです
    public float fadeOutTime = 0.1f;  //フェードアウトの開始タイミング(秒)
    private float nowTime = 0.0f;     //タイミングカウント用
    public GameObject panel;          //フェードアウト用パネルUIオブジェクト
    private Image image;              //panelのコンポーネント
    private Color color;              //panelのカラー設定
  //2022/12/13追加　ステージ番号初期化
    public int StageNumber;

    void Start()
    {
        //フェードアウト用のパラメータ取得
        image = panel.GetComponent<Image>();
        color = image.color;
        //以下キー数値の初期設定
        //「STAGE」というキーで、Int値の「StageNumber」を保存
        PlayerPrefs.SetInt("CLEARSTAGE", StageNumber);
        PlayerPrefs.Save();
        //「BGMVOLUME」というキーで、Float値の「0.5f」を保存
        PlayerPrefs.SetFloat("BGMVOLUME",0.5f);
        PlayerPrefs.Save();
        //「SEVOLUME」というキーで、Float値の「1.0f」を保存
        PlayerPrefs.SetFloat("SEVOLUME", 1.0f);
        PlayerPrefs.Save();
    }

    void Update()
    {
        //deltaTimeを加算して経過時間を計算する
        nowTime += Time.deltaTime;
        //指定の秒数が経過した際、フェードアウトしてシーンを遷移する
        if (fadeOutTime < nowTime)
        {
            //フェードアウトが終わったらシーン遷移させる
            if (color.a == 1.0f)
            {
                SceneManager.LoadScene("Title");
            }
            //アルファ値が1を超過する場合は丸め込む
            else if (color.a + Time.deltaTime > 1.0f)
            {
                color.a = 1.0f;
            }
            //アルファ値を加算する
            else
            {
                color.a += Time.deltaTime;
            }
            image.color = color;
        }
    }
    }
