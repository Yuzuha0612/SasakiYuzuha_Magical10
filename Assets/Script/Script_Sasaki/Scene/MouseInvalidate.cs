using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInvalidate : MonoBehaviour
{//�}�E�X�������X�N���v�g�ł��B�S�ẴV�[���ɓ���Ă�������
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {//�G�X�P�[�v�L�[�Ń}�E�X�J�[�\������
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
