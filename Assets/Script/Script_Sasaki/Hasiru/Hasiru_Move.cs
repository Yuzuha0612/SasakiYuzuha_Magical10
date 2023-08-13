using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Move : MonoBehaviour
{
    //moveSpeed 主人公の速さ
    public float moveSpeed;
    private Rigidbody rb;
    private float movementInputValue;
    public float JumpTimeCountUp;
    public float jumpupSpeed;
    public float jumpdownSpeed;
    private bool isJumping = false;
    //2022/11/13追加
    private bool isWallStop;
    public Vector3 colPosition;
    //2022/11/23追加 ゲーム開始判定
    bool isStart = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //2022/11/23追加 ゲーム開始判定
        //2022/11/23追加 ゲーム開始判定 全てのキー対応
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        HasiruJump();
        if (isStart == true)
        {
            //左右キーで移動
            movementInputValue = Input.GetAxis("Horizontal");
            Vector3 movement = transform.right * movementInputValue * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
            //スペースでジャンプ
            if (Input.GetKey(KeyCode.Space) && isJumping == false)
            {
                //2022/11/13追加
                isWallStop = false;
                rb.velocity = Vector3.up * jumpupSpeed;
                JumpTimeCountUp += Time.deltaTime;
                isJumping = true;
                if (JumpTimeCountUp > 3.0f)
                {
                    Debug.Log("落下中");
                    rb.velocity = Vector3.up * -jumpdownSpeed;
                    JumpTimeCountUp = 0;
                }
            }
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("Elevator"))
        {
            isJumping = false;
        }

        //2022/11/13追加
        if (collision.gameObject.tag == "Wall")
        {
            isJumping = false;
            isWallStop = true;
            colPosition = this.transform.position;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            isWallStop = false;
        }
    }
    private void HasiruJump()
    {
        if (isWallStop)
        {//壁ジャンプ、壁に当たったらRigidbodyのisKinematicにチェックを入れる
            //→壁とは反対に斜め上に一定秒数力を加える(壁とは反対・・・？壁の位置関係を取って反対に入れる？)
            gameObject.transform.position = colPosition;
        }
    }
}
