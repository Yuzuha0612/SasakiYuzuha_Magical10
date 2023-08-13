using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInvalidate : MonoBehaviour
{//マウス無効化スクリプトです。全てのシーンに入れてください
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {//エスケープキーでマウスカーソル復活
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
