using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dossun_Move : MonoBehaviour
{//FallDossunSpeed 落ちる速さ  ReloadDossunSpeed 戻る速さ　 startDossunposition 始点 lastDossunposition 終点
    //落ちる速さを早く、戻る遅さをゆっくりにすると良い感じの動きになります
    public float startDossunposition;
    public float lastDossunposition;
    public float FallDossunSpeed;
    public float ReloadDossunSpeed;
    //2022/12/10 ドッスン落ちるときの顔
    public GameObject TuraraFaceDown;
    public GameObject TuraraFaceUp;

    private Vector3 Dossunpos;
    public bool isStopAbilityDossun;
    private bool isStop = false;
    //2022/11/29追加 ゲーム開始判定
    bool isStart = false;
    void Start()
    {
        Dossunpos = transform.position;
        isStart = false;
      //  GameObject TuraraFaceDownobject = TuraraFaceDown;
    }
    void Update()
    {
        //2022/11/29追加 ゲーム開始判定
        //2022/11/23追加 ゲーム開始判定 全てのキー対応
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
