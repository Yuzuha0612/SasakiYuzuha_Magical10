using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAdministrator : MonoBehaviour
{
    public enum Magical10GameStatus
    {
        Ready,
        Game,
        TimeStop,
        Option,
        Finish
    }
    public Magical10GameStatus GameStatus;
    void Start()
    {
       GameStatus = Magical10GameStatus.Ready;
    }

    void Update()
    {
        switch(GameStatus)
        {

            case Magical10GameStatus.Ready:
                Debug.Log("�Q�[���J�n");
                break;
            case Magical10GameStatus.Game:
                Debug.Log("�Q�[����");
                break;
            case Magical10GameStatus.TimeStop:
                Debug.Log("���Ԓ�~��");
                break;
            case Magical10GameStatus.Option:
                Debug.Log("�I�v�V�������");
                break;
            case Magical10GameStatus.Finish:
                Debug.Log("�Q�[���I��");
                break;
        }
    }
}
