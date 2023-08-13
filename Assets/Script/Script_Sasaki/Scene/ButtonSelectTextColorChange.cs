using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelectTextColorChange : MonoBehaviour
{//ボタンのテキストの色変えるスクリプト
    public Text ButtunTextSelectChangeColor;
    public Text ButtunTextSelectNotChangeColor;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TextColorChangeSelect()
    {//選択したボタンと選択していないボタンの色を変える
        ButtunTextSelectChangeColor.enabled = false;
        ButtunTextSelectNotChangeColor.enabled = true;
        //ButtunTextNotSelectChangeColor01.color = ButtunTextNotSelectColor;
        //ButtunTextNotSelectChangeColor02.color = ButtunTextNotSelectColor;
    }
    public void TextColorChangeDeselect()
    {
        ButtunTextSelectChangeColor.enabled = true;
        ButtunTextSelectNotChangeColor.enabled = false;
    }
}
