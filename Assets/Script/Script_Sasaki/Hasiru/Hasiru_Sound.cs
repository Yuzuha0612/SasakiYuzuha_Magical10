using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AddComponento��Audio��AudioSource�Ŏ�l����AudioSource�����Ă�������(AudioClip��None�ő��v�ł�)
public class Hasiru_Sound : MonoBehaviour
{
    public AudioClip JumpSE;//�W�����v���ʉ�
    public AudioClip HighJumpSE;// �n�C�W�����v���ʉ�
    public AudioClip SabodonSE;// �T�{�h�����ʉ�
    public AudioClip TimeStopIn;//2023/1/8�ǉ��@���Ԓ�~�\�͊J�n�̉�
    public AudioClip TimeStopOut;//2023/1/8�ǉ��@���Ԓ�~�I���̉�
    public AudioClip TimeStoppingSE;//2023/1/8�ǉ��@���Ԓ�~���̉�
    private bool isJumping = false;
    private bool isTimeStopIn = false;
    private bool isTimeStopOut = false;
    private Rigidbody Sanarb;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //Sanarb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //�X�y�[�X�ŃW�����v
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            audioSource.PlayOneShot(JumpSE);//�W�����v���ʉ�
        }
        /*
         * Debug.Log(Sanarb.velocity.magnitude);
        if (Sanarb.velocity>0)
        {
            audioSource.PlayOneShot(TimeStopIn);//2023/1/8�ǉ��@���Ԓ�~�\�͊J�n�̉�
        }
        if (isTimeStopOut == true)
        {
            audioSource.PlayOneShot(TimeStopOut);//2023/1/8�ǉ��@���Ԓ�~�I���̉�
        }
        
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            isTimeStopIn = true;
        } else  if ((Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D)) ||( Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.RightArrow)))
        {
            isTimeStopIn = false;
        }

        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) )
        {
            isTimeStopOut = true;
        }else if (((Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.RightArrow))))
        {
            isTimeStopOut = false;
        }*/

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")|| collision.gameObject.CompareTag("Elevator"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("Robot"))
        {
            audioSource.PlayOneShot(HighJumpSE);//�n�C�W�����v���ʉ�
        }
        if (collision.gameObject.CompareTag("TogeToge"))
        {
            audioSource.PlayOneShot(SabodonSE);//�T�{�h�����ʉ�
        }

    }

}
