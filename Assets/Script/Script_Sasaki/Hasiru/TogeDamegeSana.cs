using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogeDamegeSana : MonoBehaviour
{
    private float disableKeyInputSeconds;
    public static TogeDamegeSana instance;
    //�_���[�W�A�j���[�V����
    private Animator HasiruanimatorToge;
    private string TogeStr = "isDameged";
    //���Ԓ�~�G�t�F�N�g
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
        // �������������"TogeToge"�^�O���t���Ă���ꍇ
        if (collision.gameObject.tag == "TogeToge")
        {
            // �R���[�`�����J�n
            StartCoroutine("DisableDamageInputCoroutine");

        }
    }
    void Start()
    {
        this.HasiruanimatorToge = GetComponent<Animator>();
    }

    void Update()
    {
        //�_���[�W�A�j���[�V�����L��
        //this.HasiruanimatorToge.SetBool(TogeStr, true);
        //�_���[�W�A�j���[�V��������
        //this.HasiruanimatorToge.SetBool(TogeStr, false);
    }
    private IEnumerator DisableDamageInputCoroutine()
    {
        TimeStoppingEffect.SetActive(false);
        this.HasiruanimatorToge.SetBool(TogeStr, true);
        // �w�肵���b���҂�
        yield return new WaitForSeconds(disableKeyInputSeconds);
        TimeStoppingEffect.SetActive(true);
        this.HasiruanimatorToge.SetBool(TogeStr, false);
    }
    }
