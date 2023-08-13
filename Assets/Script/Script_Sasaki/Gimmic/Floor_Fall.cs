using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Fall : MonoBehaviour
{
    //FallSpeed 落ちる速さ 　FallDistance 落ちる終点  FallStart 初期位置
    public float FallDistance;
    public float FallSpeed;
    public float FallStart;
    public bool isStopAbilityFallFloor;
    private Vector3 Floorpos;
    public bool FallStartNow;
    void Start()
    {
        Floorpos = transform.position;
    }

    void Update()
    {
        if (FallStartNow == true)
        {
            FallFloor();
        }
        else if (FallStartNow == false)
        {

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hasiru"))
        {
            FallStartNow = true;
        }
    }
    void FallFloor()
    {
        // FallDistanceだけ下に落ちる
        Floorpos.y -= Time.deltaTime * FallSpeed;
        transform.position = Floorpos;
        // FallDistanceになったら見えなくする
        if (Floorpos.y < FallDistance)
        {
            this.gameObject.SetActive(false);
            // 3秒後に復活する
            Invoke("Revival", 3);
        }
    }
    void Revival()
    {
        //このメゾットが呼び出されたら復活
        this.gameObject.SetActive(true);
        Floorpos.y = FallStart;
        transform.position = Floorpos;
        FallStartNow = false;
    }
}
