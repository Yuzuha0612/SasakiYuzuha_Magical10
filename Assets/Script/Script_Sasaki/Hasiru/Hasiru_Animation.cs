using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Animation : MonoBehaviour
{
    private Animator Hasiruanimator;
    private string runStr = "isRun";
    private string JumpStr = "isJump";

    //2022/11/23追加 ゲーム開始判定
    bool isStart = false;
    void Start()
    {
        this.Hasiruanimator = GetComponent<Animator>();
    }
    void Update()
    {

        //2022/11/23追加 ゲーム開始判定
        //2022/11/23追加 ゲーム開始判定 全てのキー対応
        if (isStart == false && Input.anyKey)
            //Input.GetKey(KeyCode.Return))
        {
            isStart = true;
        }
        //左右キー、スペースキーが押されたらアニメーション再生
        if (isStart == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                this.Hasiruanimator.SetBool(runStr, true);
            }
            else
            {
                this.Hasiruanimator.SetBool(runStr, false);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.Hasiruanimator.SetBool(JumpStr, true);
            }
            else
            {
                this.Hasiruanimator.SetBool(JumpStr, false);
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                this.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
        }
    }
}
