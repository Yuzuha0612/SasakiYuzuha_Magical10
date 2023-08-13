using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Scene : MonoBehaviour
{
    [SerializeField] Image StageSelectImage;
    [SerializeField] Button StageSelectButton;
    [SerializeField] Text StageSelectText;
    [SerializeField] Button FirstStageButton;
    [SerializeField] Image FirstStageImage;
    [SerializeField] Text FirstStageText;
    [SerializeField] Button ReturnButton;
    [SerializeField] Image ReturnImage;
    [SerializeField] Text ReturnText;
    //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンををGameStartとしてFirstGameStartButtonに入れる
    [SerializeField] Button FirstGameStartButton;
  


    void Start()
    {
        //「STAGE」というキーで保存されているInt値を読み込み
        int StageReload = PlayerPrefs.GetInt("CLEARSTAGE");
        //もし「STAGE」が0以上なら試験選択ボタンを白色にする
        if (StageReload  >= 0 )
        {
            StageSelectImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
      
    }

    void Update()
    {//2023/1/7追加マウス入力すると試験開始を選択させる
        if ((Input.GetMouseButtonDown(0)) &&(StageSelectButton.enabled==true))
        {
            FirstStageButton.Select();
            //FirstGameStartButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if  (Input.GetMouseButtonDown(0)&& (StageSelectButton.enabled == false))
            {
            FirstGameStartButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void OnStartButtonClicked()
    {//試験開始ボタンを押すと最初から始めるボタンとステージ選択ボタン、戻るボタンが表示される
        StageSelectImage.enabled = true;
        StageSelectButton.enabled = true;
        StageSelectText.enabled = true;
        FirstStageButton.enabled = true;
        FirstStageImage.enabled = true;
        FirstStageText.enabled = true;
        ReturnButton.enabled = true;
        ReturnImage.enabled = true;
        ReturnText.enabled = true;
        //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンを指示する
        FirstStageButton.Select();
    }
    public void OnReturnButtonClicked()
    {//戻るボタンを押すと最初から始めるボタンとステージ選択ボタン、戻るボタンが非表示にされる
        StageSelectImage.enabled = false;
        StageSelectButton.enabled = false;
        StageSelectText.enabled = false;
        FirstStageButton.enabled = false;
        FirstStageImage.enabled = false;
        FirstStageText.enabled = false;
        ReturnButton.enabled = false;
        ReturnImage.enabled = false;
        ReturnText.enabled = false;
        FirstGameStartButton.Select();
    }
    public void OnStageSelectButtonClicked()
    {
        //「STAGE」というキーで保存されているInt値を読み込み
        int StageReload = PlayerPrefs.GetInt("CLEARSTAGE");
        //もし「CLEARSTAGE」が0以上なら試験選択画面に移行
        if (StageReload >= 0)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("StageSelect", 0.5f);
        }
    }
}
