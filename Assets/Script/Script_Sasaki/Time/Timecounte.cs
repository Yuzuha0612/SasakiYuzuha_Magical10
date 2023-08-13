using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class Timecounte : MonoBehaviour
{
    //timeCount 制限時間　スクリプトはMainCameraに入れてます
    public Text timeLabel;
    public float timeCount;
    //2022/11/27追加　現在のステージ番号
    public int StageNumber;
    //2022/11/27追加　現在の級
    public int StageClass;
    //2022/11/23追加 ゲーム開始判定
    bool isStart = false;
    public int TimeCountint;
    [SerializeField] Text StartClickEnter;
    public GameObject GoalObject;
    public GameObject GameOverArea;
    //public GameObject Sabodon;
    //2022年12月9日追加　時間停止エフェクトを取得するため、MainCameraをTimeStopPostProcessLayerに入れる
    public PostProcessLayer TimeStopPostProcessLayer;
    public AudioClip GameOverSE;//落ちるときの効果音
    AudioSource audioSource;
    //2023/1/4追加　赤色のストップウォッチのイラストをTimeImageRedにいれる
    public Image TimeImageRed;
    //2023/2/22追加　ゲームマネージャー取得
    private GameAdministrator gameAdministrator;
    public GameObject Administrator;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        timeCount = 10;
        timeLabel.text = "TIME:" + timeCount; //fixapdate
        GoalObject = GameObject.FindGameObjectWithTag("Goal");
        GameOverArea = GameObject.FindGameObjectWithTag("GameOverArea");
        //Sabodon = GameObject.FindGameObjectWithTag("TogeToge");
        //2022年12月9日追加　時間停止エフェクトをオフにする
        //TimeStopPostProcessLayer.enabled = false;
        //「STAGECLASS」というキーで、Int値の「StageClass」を保存
        PlayerPrefs.SetInt("STAGECLASS", StageClass);
        PlayerPrefs.Save();
        //2023/2/22追加　ゲームマネージャー取得
        gameAdministrator = Administrator.GetComponent<GameAdministrator>();
    }

    void Update()
    {

        //2022/11/23追加 ゲーム開始判定
        //2022/11/23追加 ゲーム開始判定 全てのキー対応
        //2023/2/22追加　ゲームマネージャー判定追加
        if (isStart == false && Input.anyKey&& gameAdministrator.GameStatus == GameAdministrator.Magical10GameStatus.Ready)
        {
            isStart = true;
            StartClickEnter.enabled = false;
            gameAdministrator.GameStatus = GameAdministrator.Magical10GameStatus.Game;
        }
        if (isStart == true )
        {
            //左右キーのどちらかが押されたとき時間を引くのを止めるそれ以外はTimedeltaTimeで時間経過 && Sabodon.GetComponent<Sabodon>().isTogeDamege
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) &&(Sabodon. instance.isTogeDamege))
            {
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
                gameAdministrator.GameStatus = GameAdministrator.Magical10GameStatus.TimeStop;
                //2022年12月9日追加　時間停止エフェクトをオンにする
                // TimeStopPostProcessLayer.enabled = true;
            }
            else
            {
                timeCount -= Time.deltaTime;
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
                gameAdministrator.GameStatus = GameAdministrator.Magical10GameStatus.Game;
                //2022年12月9日追加　時間停止エフェクトをオフにする
                //TimeStopPostProcessLayer.enabled = false;
            }
            //2022年12月9日追加　キーを押したらペナルティとして0.1秒減らす
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
                timeCount -= 0.1f;
            }
        }
        if (timeCount < 4)
        {//2022/12/11追加　残り4秒になったら制限時間を赤色にする
         //4秒以下になったら
         //赤色にする
            timeLabel.color = new Color(1.0f, 0.0f ,0.0f ,1.0f);
            //2023/1/4追加　制限時間が4秒以下になるとストップウォッチのイラストが赤色になる
            TimeImageRed.enabled = true;

        }
        if (timeCount < 0)
        {//2022/11/27追加　ゲームオーバーから現在のステージに戻ってくる
         //0秒以下になったら
            //audioSource.PlayOneShot(GameOverSE);//ゲームオーバー効果音
            //「STAGE」というキーで、Int値の「StageNumber」を保存
            PlayerPrefs.SetInt("STAGE", StageNumber);
            PlayerPrefs.Save();
            timeLabel.text = "TIME:0.00"; 
            //ゲームオーバー画面に移動
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("GameOverTimeUp", 0.2f);
        }

        if (GoalObject.GetComponent<Goal_GameClear>().isGameClear)
        {
            GameClear_Time();
        }
        /*
        if (GameOverArea.GetComponent<GameOver_Drop>().isGameOver)
        {
            GameOver_Drop();
        }*/
    }

    private void GameClear_Time()
    {
        //2022/11/27追加　timeCountの小数点以下を切り捨て、int型に変換
        TimeCountint = (int)timeCount;
        //ゲームクリア画面移動とクリアタイム保存
        //0秒以下になったら
        //「STAGE」というキーで、Int値の「StageNumber」を保存
        PlayerPrefs.SetInt("STAGE", StageNumber);
        PlayerPrefs.Save();
        //「TIME」というキーで、Int値の「TimeCountint」を保存
        PlayerPrefs.SetInt("TIME", TimeCountint);
        PlayerPrefs.Save();
        //「TIMEFLOAT」というキーで、Float値の「TimeCountint」を保存
        PlayerPrefs.SetFloat("TIMEFLOAT", timeCount);
        PlayerPrefs.Save();
        //2023/1/11 シーン切り替え時にフェードインフェードアウトの演出を追加ゲームクリア画面に移動
        FadeManager.Instance.LoadScene("GameClear", 0.3f);
    }
    /*
    private void GameOver_Drop()
    {
       
        //「STAGE」というキーで、Int値の「StageNumber」を保存
        PlayerPrefs.SetInt("STAGE", StageNumber);
        PlayerPrefs.Save();
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("GameOver", 0.6f);
    }*/
   

}
