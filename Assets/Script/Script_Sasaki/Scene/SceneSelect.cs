using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneSelect : MonoBehaviour
{//ステージ選択画面移動ボタン
    [SerializeField] Button Stage0Button;
    [SerializeField] Button Stage1Button;
    [SerializeField] Image Stage1Image;
    [SerializeField] Button Stage2Button;
    [SerializeField] Image Stage2Image;
    [SerializeField] Button Stage3Button;
    [SerializeField] Image Stage3Image;
    [SerializeField] Button Stage4Button;
    [SerializeField] Image Stage4Image;
    [SerializeField] Button Stage5Button;
    [SerializeField] Image Stage5Image;
    [SerializeField] Button Stage6Button;
    [SerializeField] Image Stage6Image;
    [SerializeField] Button Stage7Button;
    [SerializeField] Image Stage7Image;
    [SerializeField] Button Stage8Button;
    [SerializeField] Image Stage8Image;
    [SerializeField] Button Stage9Button;
    [SerializeField] Image Stage9Image;
    [SerializeField] Button Stage10Button;
    [SerializeField] Image Stage10Image;
    void Start()
    {
        //ボタンをキー選択させるため、11級ボタンを選択する
        Stage0Button.Select();
        //2022/12/19キー名を変更「STAGECLEAR」というキーで保存されているInt値を読み込み
         int StageReload = PlayerPrefs.GetInt("CLEARSTAGE");
        //もし「STAGE」が0ならStage0までのボタンを有効
        if (StageReload == 0)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
           // Stage0Button.image.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
            Stage1Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage2Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage3Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が1ならStage1までのボタンを有効 それ以降のステージのボタンの色を灰色
        if (StageReload == 1)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage3Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が2ならStage2_Takedaまでのボタンを有効
        if (StageReload == 2)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が3ならStageEle_miuraまでのボタンを有効
        if (StageReload == 3)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が4ならStage3_miuraまでのボタンを有効
        if (StageReload == 4)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }

        //もし「STAGE」が5ならStage4_miuraまでのボタンを有効
        if (StageReload == 5)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が6ならStage5_Takedaまでのボタンを有効
        if (StageReload == 6)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Button.enabled = true;
            Stage7Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が7ならStageSabo_miuraまでのボタンを有効
        if (StageReload == 7)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Button.enabled = true;
            Stage7Button.enabled = true;
            Stage8Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が8ならStage6_Takedaまでのボタンを有効
        if (StageReload == 8)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Button.enabled = true;
            Stage7Button.enabled = true;
            Stage8Button.enabled = true;
            Stage9Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        if (StageReload == 9)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Button.enabled = true;
            Stage7Button.enabled = true;
            Stage8Button.enabled = true;
            Stage9Button.enabled = true;
            Stage10Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        if (StageReload == 10)
        {
            Stage0Button.Select();
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Button.enabled = true;
            Stage7Button.enabled = true;
            Stage8Button.enabled = true;
            Stage9Button.enabled = true;
            Stage10Button.enabled = true;
        }
    }

    void Update()
    {//2023/1/16追加 マウス入力すると11級を選択させる
       
        if (Input.GetMouseButtonDown(0) )
        {
            Stage0Button.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnStageSelectButtonClicked()
    {  //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("StageSelect", 0.5f);
    }

    public void OnStageSelect00ButtonClicked()
    {//Stage0移動ボタン
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Stage0", 0.5f);
    }
    public void OnStageSelect01ButtonClicked()
    {//StagePata_miura移動ボタン
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("StagePata_miura", 0.5f);
    }

    public void OnStageSelect02ButtonClicked()
    {//Stage1移動ボタン
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("StageTeku_miura", 0.5f);
    }
    public void OnStageSelect03ButtonClicked()
    {//Stage1移動ボタン
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Stage1", 0.5f);
    }

    public void OnStageSelect04ButtonClicked()
    {//Stage2_takeda移動ボタン
     //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Stage2_takeda", 0.5f);
    }

    public void OnStageSelect05ButtonClicked()
    {//Stage2_takeda移動ボタン
     //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("StageEle_miura", 0.5f);
    }
    public void OnStageSelect06ButtonClicked()
    {//Stage3_miura移動ボタン
        FadeManager.Instance.LoadScene("Stage3_miura", 0.5f);
    }
    public void OnStageSelect07ButtonClicked()
    {//StageSabo_miura移動ボタン
     //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("StageSabo_miura", 0.5f);
    }

    public void OnStageSelect08ButtonClicked()
    {//Stage4_miura移動ボタン
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Stage4_miura", 0.5f);
    }
    
    public void OnStageSelect09ButtonClicked()
    {//Stage5_takeda移動ボタン
     //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Stage5_takeda", 0.5f);
    }

    public void OnStageSelect10ButtonClicked()
    {//Stage6_takeda移動ボタン
     //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Stage6_takeda", 0.5f);
    }

    public void OnTitleReturnButtonClicked()
    {
        //2022/12/19　タイトルに戻る
        FadeManager.Instance.LoadScene("Title", 0.5f);
    }
}
