using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dossun_Move : MonoBehaviour
{//FallDossunSpeed �����鑬��  ReloadDossunSpeed �߂鑬���@ startDossunposition �n�_ lastDossunposition �I�_
    //�����鑬���𑁂��A�߂�x�����������ɂ���Ɨǂ������̓����ɂȂ�܂�
    public float startDossunposition;
    public float lastDossunposition;
    public float FallDossunSpeed;
    public float ReloadDossunSpeed;
    //2022/12/10 �h�b�X��������Ƃ��̊�
    public GameObject TuraraFaceDown;
    public GameObject TuraraFaceUp;

    private Vector3 Dossunpos;
    public bool isStopAbilityDossun;
    private bool isStop = false;
    //2022/11/29�ǉ� �Q�[���J�n����
    bool isStart = false;
    void Start()
    {
        Dossunpos = transform.position;
        isStart = false;
      //  GameObject TuraraFaceDownobject = TuraraFaceDown;
    }
    void Update()
    {
        //2022/11/29�ǉ� �Q�[���J�n����
        //2022/11/23�ǉ� �Q�[���J�n���� �S�ẴL�[�Ή�
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityDossun == true && isStart == true)
        {
            DossunMove();
        }
        else if (isStopAbilityDossun == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            isStopAbilityDossun = false;
        }
        else
        {
            isStopAbilityDossun = true;
        }

    }

    void DossunMove()
    {

        if (isStop == false)
        {
            Dossunpos.y += Time.deltaTime * ReloadDossunSpeed;
            transform.position = Dossunpos;
            TuraraFaceDown.SetActive(false);
            TuraraFaceUp.SetActive(true);
            if (Dossunpos.y > startDossunposition)
            {
                isStop = true;
               // TuraraFaceDown.SetActive(true);
            }
        }
        else if (isStop == true)
        {
            TuraraFaceDown.SetActive(true);
            TuraraFaceUp.SetActive(false);
            Dossunpos.y -= Time.deltaTime * FallDossunSpeed;
            transform.position = Dossunpos;
            if (Dossunpos.y < lastDossunposition)
            {
                isStop = false;
            }
        }
    }

}
