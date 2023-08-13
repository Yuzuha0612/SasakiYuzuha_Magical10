using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Fall : MonoBehaviour
{
    //FallSpeed �����鑬�� �@FallDistance ������I�_  FallStart �����ʒu
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
        // FallDistance�������ɗ�����
        Floorpos.y -= Time.deltaTime * FallSpeed;
        transform.position = Floorpos;
        // FallDistance�ɂȂ����猩���Ȃ�����
        if (Floorpos.y < FallDistance)
        {
            this.gameObject.SetActive(false);
            // 3�b��ɕ�������
            Invoke("Revival", 3);
        }
    }
    void Revival()
    {
        //���̃��]�b�g���Ăяo���ꂽ�畜��
        this.gameObject.SetActive(true);
        Floorpos.y = FallStart;
        transform.position = Floorpos;
        FallStartNow = false;
    }
}
