using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Move_ver2 : MonoBehaviour
{
    // x�������Ɍ��߂�ꂽ�P����͂̈ړ�����
    public Vector3 moveX = new Vector3(1.0f, 0.0f, 0.0f);
    // �ړ������̑��x�ƖڕW�ʒu�̕ϐ�
    public float speed = 7.0f;
    Vector3 target;
    Rigidbody rigid;
    void Start()
    {
        target = transform.position;
        rigid = GetComponent<Rigidbody>();//�ϐ����͋��ʂ���(�܂Ƃ߂Ă����A���̐l�ƍ�Ƃ���Ƃ��ɕK�{)�@��Ƃ̕��S�̓X�N���v�g��������Ȃ��悤�ɂ���A�X�N���v�g �ϐ���c�����Ă���(���[�h�v���O���}�[�̎d��)
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
