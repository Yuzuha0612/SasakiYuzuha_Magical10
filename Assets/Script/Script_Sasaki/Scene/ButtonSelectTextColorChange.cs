using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelectTextColorChange : MonoBehaviour
{//�{�^���̃e�L�X�g�̐F�ς���X�N���v�g
    public Text ButtunTextSelectChangeColor;
    public Text ButtunTextSelectNotChangeColor;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TextColorChangeSelect()
    {//�I�������{�^���ƑI�����Ă��Ȃ��{�^���̐F��ς���
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
