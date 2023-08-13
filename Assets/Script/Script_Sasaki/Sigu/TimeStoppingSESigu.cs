using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStoppingSESigu : MonoBehaviour
{
    public AudioClip TimeStopIn;//2023/1/8�ǉ��@���Ԓ�~�\�͊J�n�̉�
    public AudioClip TimeStopOut;//2023/1/8�ǉ��@���Ԓ�~�I���̉�
    AudioSource audioSource;
    private bool isTimeStopIn = false;
    private bool isTimeStopOut = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))) && isTimeStopIn==false)
        {
            isTimeStopIn = true;
            audioSource.PlayOneShot(TimeStopIn);
        }
        if ((Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.RightArrow)))
        {
            isTimeStopIn = false;
            audioSource.PlayOneShot(TimeStopOut);
        }
    }
}
