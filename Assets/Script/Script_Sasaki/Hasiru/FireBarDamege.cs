using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBarDamege : MonoBehaviour
{
	[SerializeField]
	[Tooltip("キー入力を無効にする秒数")]
	private float disableKeyInputSeconds;
	public static FireBarDamege instance;
	public bool isFireDamege;
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
		isFireDamege = true;
		DamegeEffect.SetActive(false);


	}
	private void OnTriggerEnter(Collider other)
	{
		// 通過した相手に"Fire"タグが付いている場合
		if (other.gameObject.tag == "Fire")
		{
			// コルーチンを開始
			StartCoroutine("DisableKeyInputCoroutine");

		}
	}

	private IEnumerator DisableKeyInputCoroutine()
	{
		Debug.Log("ファイア");
		GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
		// 移動無効
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = false;
		isFireDamege = false;
		//ダメージエフェクト有効
		DamegeEffect.SetActive(true);

		// 指定した秒数待つ
		yield return new WaitForSeconds(disableKeyInputSeconds);
		Debug.Log("ファイア終了");
		//移動を元に戻す
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = true;
		isFireDamege = true;
		//ダメージエフェクト無効
		DamegeEffect.SetActive(false);

	}
}
