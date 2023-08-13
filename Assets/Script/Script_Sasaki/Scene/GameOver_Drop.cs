using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Drop : MonoBehaviour
{

    public AudioClip GameOverDropSE;//落ちるときの効果音
    AudioSource audioSource;
    public bool isGameOver;
    //2022/11/27追加　現在のステージ番号
    public int StageNumber;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isGameOver = false;
    }
    //ゴールにぶつかったらゴールシーンに移動する
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"Hasrtu"タグが付いている場合
        //TimeCountのGameOver_Timeを実行するため、isGameOverをtrueにする
        if (collision.gameObject.tag == "Hasiru")
        {
            audioSource.PlayOneShot(GameOverDropSE);//ゲームオーバー効果音
            //「STAGE」というキーで、Int値の「StageNumber」を保存
            PlayerPrefs.SetInt("STAGE", StageNumber);
            PlayerPrefs.Save();
            // isGameOver = true;
            FadeManager.Instance.LoadScene("GameOver", 0.6f);
        }
    }
}
