using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuraraDamege : MonoBehaviour
{
    public float bounceTuraraSpeed;
    public float bounceVectorTuraraMultiple;
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"Hasrtu"タグが付いている場合
        if (collision.gameObject.tag == "Hasiru")
        {
            // 衝突した面の、接触した点における法線ベクトルを取得
            Vector3 normal = collision.contacts[0].normal;
            // 衝突した速度ベクトルを単位ベクトルにする
            Vector3 velocity = collision.rigidbody.velocity.normalized;
            // x,z方向に対して逆向きの法線ベクトルを取得
            velocity += new Vector3(-normal.x * bounceVectorTuraraMultiple, 0f, 0f);
            // 取得した法線ベクトルに跳ね返す速さをかけて、跳ね返す
            //固定 一定の力で跳ね返す　ベクトルを入れる　
            collision.rigidbody.AddForce(velocity * bounceTuraraSpeed, ForceMode.Impulse);
            // collision.rigidbody.AddForce( bounceSpeed, ForceMode.Impulse);
        }
    }
}
