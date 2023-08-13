using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_SelectKey : MonoBehaviour
{//�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������L�[���w������
    public Button FirstButton;
    void Start()
    {
       // Firstbutton = GameObject.Find("Canvas/Button/").GextComponent<Button>();
      FirstButton.Select();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FirstButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
