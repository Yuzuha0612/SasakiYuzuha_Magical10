using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_SizeChange : MonoBehaviour
{
    // 属性の設定これによりスクリプトをアタッチしなくても実行されるようになる
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        //Debug.Log("After Scene is loaded and game is running");
        // スクリーンサイズの指定
        Screen.SetResolution(1280, 720, false);
    }
}
