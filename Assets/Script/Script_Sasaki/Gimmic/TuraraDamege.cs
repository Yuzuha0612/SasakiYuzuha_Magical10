using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuraraDamege : MonoBehaviour
{
    public float bounceTuraraSpeed;
    public float bounceVectorTuraraMultiple;
    private void OnCollisionEnter(Collision collision)
    {
        // �������������"Hasrtu"�^�O���t���Ă���ꍇ
        if (collision.gameObject.tag == "Hasiru")
        {
            // �Փ˂����ʂ́A�ڐG�����_�ɂ�����@���x�N�g�����擾
            Vector3 normal = collision.contacts[0].normal;
            // �Փ˂������x�x�N�g����P�ʃx�N�g���ɂ���
            Vector3 velocity = collision.rigidbody.velocity.normalized;
            // x,z�����ɑ΂��ċt�����̖@���x�N�g�����擾
            velocity += new Vector3(-normal.x * bounceVectorTuraraMultiple, 0f, 0f);
            // �擾�����@���x�N�g���ɒ��˕Ԃ������������āA���˕Ԃ�
            //�Œ� ���̗͂Œ��˕Ԃ��@�x�N�g��������@
            collision.rigidbody.AddForce(velocity * bounceTuraraSpeed, ForceMode.Impulse);
            // collision.rigidbody.AddForce( bounceSpeed, ForceMode.Impulse);
        }
    }
}
