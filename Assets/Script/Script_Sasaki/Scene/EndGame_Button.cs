using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame_Button : MonoBehaviour
{
    //背景
    [SerializeField] Image EndGameWarningImage;
    //いいえボタン
    [SerializeField] Button EndGameWarningCloseButton;
    [SerializeField] Image EndGameWarningCloseImage;
    [SerializeField] Text EndGameWarningCloseText;
    [SerializeField] Text EndGameWarningCloseSelectText;
    //ゲーム終了しますかテキスト
    [SerializeField] Text EndGameWarningText;
    //はいボタン
    [SerializeField] Button EndGameButton;
    [SerializeField] Image EndGameImage;
    [SerializeField] Text EndGameText;
    //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンをGameStartとしてFirstGameStartButtonに入れる
    [SerializeField] Button FirstGameStartButton;
    //
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (EndGameWarningCloseButton.enabled == true))
        {
            EndGameWarningCloseButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnEndGameFirstButtonClicked()
    {//最初にゲーム終了ボタンを押すとゲーム終了警告画面が表示される
        EndGameWarningImage.enabled = true;
        EndGameWarningText.enabled = true;
        EndGameWarningCloseButton.enabled = true;
        EndGameWarningCloseImage.enabled = true;
        EndGameWarningCloseText.enabled = true;
        EndGameButton.enabled = true;
        EndGameImage.enabled = true;
        EndGameText.enabled = true;
        //2022/12/5追加　ボタンをキー選択させるため、いいえボタンを選択する
        EndGameWarningCloseButton.Select();
    }

    public void OnEndGameSecondButtonOffClicked()
    {//はいを押すとゲームを終了する
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }
    public void OnEndGameWarningButtonOffClicked()
    {//いいえを押すとステージ選択画面に戻る
        EndGameWarningImage.enabled = false;
        EndGameWarningText.enabled = false;
        EndGameWarningCloseButton.enabled = false;
        EndGameWarningCloseImage.enabled = false;
        EndGameWarningCloseText.enabled = false;
        EndGameButton.enabled = false;
        EndGameImage.enabled = false;
        EndGameText.enabled = false; 
        EndGameWarningCloseSelectText.enabled = false;
        //2022/12/5追加　ボタンをキー選択させるため、試験開始ボタンを選択する
        FirstGameStartButton.Select();
    }
}
