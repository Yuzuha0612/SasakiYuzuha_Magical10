using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_SizeChange : MonoBehaviour
{
    // �����̐ݒ肱��ɂ��X�N���v�g���A�^�b�`���Ȃ��Ă����s�����悤�ɂȂ�
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        //Debug.Log("After Scene is loaded and game is running");
        // �X�N���[���T�C�Y�̎w��
        Screen.SetResolution(1280, 720, false);
    }
}
