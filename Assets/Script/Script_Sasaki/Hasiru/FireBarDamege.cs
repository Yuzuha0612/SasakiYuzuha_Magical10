using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBarDamege : MonoBehaviour
{
	[SerializeField]
	[Tooltip("�L�[���͂𖳌��ɂ���b��")]
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
		// �ʉ߂��������"Fire"�^�O���t���Ă���ꍇ
		if (other.gameObject.tag == "Fire")
		{
			// �R���[�`�����J�n
			StartCoroutine("DisableKeyInputCoroutine");

		}
	}

	private IEnumerator DisableKeyInputCoroutine()
	{
		Debug.Log("�t�@�C�A");
		GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
		// �ړ�����
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = false;
		isFireDamege = false;
		//�_���[�W�G�t�F�N�g�L��
		DamegeEffect.SetActive(true);

		// �w�肵���b���҂�
		yield return new WaitForSeconds(disableKeyInputSeconds);
		Debug.Log("�t�@�C�A�I��");
		//�ړ������ɖ߂�
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = true;
		isFireDamege = true;
		//�_���[�W�G�t�F�N�g����
		DamegeEffect.SetActive(false);

	}
}
