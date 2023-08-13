using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogeDamegeSana : MonoBehaviour
{
    private float disableKeyInputSeconds;
    public static TogeDamegeSana instance;
    //ダメージアニメーション
    private Animator HasiruanimatorToge;
    private string TogeStr = "isDameged";
    //時間停止エフェクト
    public GameObject TimeStoppingEffect;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"TogeToge"タグが付いている場合
        if (collision.gameObject.tag == "TogeToge")
        {
            // コルーチンを開始
            StartCoroutine("DisableDamageInputCoroutine");

        }
    }
    void Start()
    {
        this.HasiruanimatorToge = GetComponent<Animator>();
    }

    void Update()
    {
        //ダメージアニメーション有効
        //this.HasiruanimatorToge.SetBool(TogeStr, true);
        //ダメージアニメーション無効
        //this.HasiruanimatorToge.SetBool(TogeStr, false);
    }
    private IEnumerator DisableDamageInputCoroutine()
    {
        TimeStoppingEffect.SetActive(false);
        this.HasiruanimatorToge.SetBool(TogeStr, true);
        // 指定した秒数待つ
        yield return new WaitForSeconds(disableKeyInputSeconds);
        TimeStoppingEffect.SetActive(true);
        this.HasiruanimatorToge.SetBool(TogeStr, false);
    }
    }
