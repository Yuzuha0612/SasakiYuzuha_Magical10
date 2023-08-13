using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Move_ver2 : MonoBehaviour
{
    // x軸方向に決められた１回入力の移動距離
    public Vector3 moveX = new Vector3(1.0f, 0.0f, 0.0f);
    // 移動距離の速度と目標位置の変数
    public float speed = 7.0f;
    Vector3 target;
    Rigidbody rigid;
    void Start()
    {
        target = transform.position;
        rigid = GetComponent<Rigidbody>();//変数名は共通する(まとめておく、他の人と作業するときに必須)　作業の分担はスクリプトをいじらないようにする、スクリプト 変数を把握しておく(リードプログラマーの仕事)
        rigid.useGravity = false;
        rigid.isKinematic = true;
    }

    void Update()
    {
        TargetPosition();
        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
    }
    void TargetPosition()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            target = transform.position + moveX;
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            target = transform.position - moveX;
            return;
        }
    }
}
