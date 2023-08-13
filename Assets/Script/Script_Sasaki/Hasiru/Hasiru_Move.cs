using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Move : MonoBehaviour
{
    //moveSpeed ��l���̑���
    public float moveSpeed;
    private Rigidbody rb;
    private float movementInputValue;
    public float JumpTimeCountUp;
    public float jumpupSpeed;
    public float jumpdownSpeed;
    private bool isJumping = false;
    //2022/11/13�ǉ�
    private bool isWallStop;
    public Vector3 colPosition;
    //2022/11/23�ǉ� �Q�[���J�n����
    bool isStart = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //2022/11/23�ǉ� �Q�[���J�n����
        //2022/11/23�ǉ� �Q�[���J�n���� �S�ẴL�[�Ή�
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        HasiruJump();
        if (isStart == true)
        {
            //���E�L�[�ňړ�
            movementInputValue = Input.GetAxis("Horizontal");
            Vector3 movement = transform.right * movementInputValue * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
            //�X�y�[�X�ŃW�����v
            if (Input.GetKey(KeyCode.Space) && isJumping == false)
            {
                //2022/11/13�ǉ�
                isWallStop = false;
                rb.velocity = Vector3.up * jumpupSpeed;
                JumpTimeCountUp += Time.deltaTime;
                isJumping = true;
                if (JumpTimeCountUp > 3.0f)
                {
                    Debug.Log("������");
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

        //2022/11/13�ǉ�
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
        {//�ǃW�����v�A�ǂɓ���������Rigidbody��isKinematic�Ƀ`�F�b�N������
            //���ǂƂ͔��΂Ɏ΂ߏ�Ɉ��b���͂�������(�ǂƂ͔��΁E�E�E�H�ǂ̈ʒu�֌W������Ĕ��΂ɓ����H)
            gameObject.transform.position = colPosition;
        }
    }
}
