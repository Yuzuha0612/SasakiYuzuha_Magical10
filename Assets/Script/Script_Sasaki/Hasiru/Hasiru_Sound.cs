using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AddComponento→Audio→AudioSourceで主人公にAudioSourceをつけてください(AudioClipはNoneで大丈夫です)
public class Hasiru_Sound : MonoBehaviour
{
    public AudioClip JumpSE;//ジャンプ効果音
    public AudioClip HighJumpSE;// ハイジャンプ効果音
    public AudioClip SabodonSE;// サボドン効果音
    public AudioClip TimeStopIn;//2023/1/8追加　時間停止能力開始の音
    public AudioClip TimeStopOut;//2023/1/8追加　時間停止終了の音
    public AudioClip TimeStoppingSE;//2023/1/8追加　時間停止中の音
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
        //スペースでジャンプ
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            audioSource.PlayOneShot(JumpSE);//ジャンプ効果音
        }
        /*
         * Debug.Log(Sanarb.velocity.magnitude);
        if (Sanarb.velocity>0)
        {
            audioSource.PlayOneShot(TimeStopIn);//2023/1/8追加　時間停止能力開始の音
        }
        if (isTimeStopOut == true)
        {
            audioSource.PlayOneShot(TimeStopOut);//2023/1/8追加　時間停止終了の音
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
            audioSource.PlayOneShot(HighJumpSE);//ハイジャンプ効果音
        }
        if (collision.gameObject.CompareTag("TogeToge"))
        {
            audioSource.PlayOneShot(SabodonSE);//サボドン効果音
        }

    }

}
