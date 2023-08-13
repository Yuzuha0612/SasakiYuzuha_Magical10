using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OperationSelect : MonoBehaviour
{
    [SerializeField] Image ExplanationImage;
    [SerializeField] Button ExplanationCloseButton;
    [SerializeField] Button ExplanationCloseAndFirstStageButton;
    [SerializeField] Image ExplanationCloseAndFirstStageImage;
    [SerializeField] Image ExplanationImageCloseButton;
    [SerializeField] RawImage ExplanationMovieWalk;
    [SerializeField] RawImage ExplanationMovieJump;
    [SerializeField] Text ExplanationTextWalk;
    [SerializeField] Text ExplanationTextJump;
    //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンをGameStartとしてFirstGameStartButtonに入れる
    [SerializeField] Button FirstGameStartButton;
  
    void Start()
    {
    }
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (ExplanationCloseButton.enabled == true))
        {
            //マウスをクリックすると操作説明画像が非表示にされる
            ExplanationImage.enabled = false;
            ExplanationCloseButton.enabled = false;
            ExplanationImageCloseButton.enabled = false;
            ExplanationMovieWalk.enabled = false;
            ExplanationMovieJump.enabled = false;
            ExplanationTextWalk.enabled = false;
            ExplanationTextJump.enabled = false;
            //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンを指示する
            FirstGameStartButton.Select();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnOperationExplanationButtonClicked()
    {//操作説明ボタンを押すと操作説明画像が表示される
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationImageCloseButton.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
        //2022/12/5追加　ボタンをキー選択させるため、×ボタンを選択する
        ExplanationCloseButton.Select();
    }

    public void OnOperationExplanationButtonOffClicked()
    {//×ボタンを押すと操作説明画像が非表示にされる
        ExplanationImage.enabled = false;
        ExplanationCloseButton.enabled = false;
        ExplanationImageCloseButton.enabled = false;
        ExplanationMovieWalk.enabled = false;
        ExplanationMovieJump.enabled = false;
        ExplanationTextWalk.enabled = false;
        ExplanationTextJump.enabled = false;
        //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンを指示する
        FirstGameStartButton.Select();
    }

    public void OnOperationExplanationButtonAndFirstStageClicked()
    {//最初から始めるを押すと操作説明画像が表示される
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationCloseAndFirstStageButton.enabled = true;
        ExplanationCloseAndFirstStageImage.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
        //2022/12/5追加　ボタンをキー選択させるため、×ボタンを選択する
        ExplanationCloseAndFirstStageButton.Select();
    }
    public void OnOperationExplanationButtonOffAndFirstStageClicked()
    {
        //×ボタンを押すと操作説明画像が非表示にされる
        //最初のステージに進む
        ExplanationImage.enabled = false;
        ExplanationCloseButton.enabled = false;
        ExplanationCloseAndFirstStageButton.enabled = false;
        ExplanationCloseAndFirstStageImage.enabled = false;
        ExplanationMovieWalk.enabled = false;
        ExplanationMovieJump.enabled = false;
        ExplanationTextWalk.enabled = false;
        ExplanationTextJump.enabled = false;
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
       FadeManager.Instance.LoadScene("Stage0",0.5f);
    }
  
    }

