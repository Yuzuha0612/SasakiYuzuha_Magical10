using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sabodon : MonoBehaviour
{
	[SerializeField]
	[Tooltip("キー入力を無効にする秒数")]
	private float disableKeyInputSeconds;
	public static Sabodon instance;
	public bool isTogeDamege;
	public GameObject DamegeEffect;
	
	public void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}
	void Start()
	{
		isTogeDamege = true;
		DamegeEffect.SetActive(false);
		
	
	}
    private void OnCollisionEnter(Collision collision)
	{
		// 当たった相手に"TogeToge"タグが付いている場合
		if (collision.gameObject.tag == "TogeToge")
		{
			// コルーチンを開始
			StartCoroutine("DisableKeyInputCoroutine");
			
		}
	}

	private IEnumerator DisableKeyInputCoroutine()
	{
		Debug.Log("トゲトゲ");
		GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
		// 移動無効
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = false;
		isTogeDamege = false;
		//ダメージエフェクト有効
		DamegeEffect.SetActive(true);
		
		//時間停止能力無効
		//Hasiru1.gameObject.GetComponent<StopAbility>().enabled = false;
		// アニメーション無効
		//Hasiru1.gameObject.GetComponent<Hasiru_Animation>().enabled = false;

		// 指定した秒数待つ
		yield return new WaitForSeconds(disableKeyInputSeconds);
		Debug.Log("トゲトゲ終了");
		//移動を元に戻す
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = true;
		isTogeDamege = true;
		//ダメージエフェクト無効
		DamegeEffect.SetActive(false);
		
		//時間停止能力有効
		//Hasiru1.gameObject.GetComponent<StopAbility>().enabled = true;
		// アニメーションを元に戻す
		//Hasiru1.gameObject.GetComponent<Hasiru_Animation>().enabled = true;
	}
}
