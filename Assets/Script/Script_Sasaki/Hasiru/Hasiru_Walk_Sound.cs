using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Walk_Sound : MonoBehaviour
{
    public AudioClip FootWalkSE;//ë´âπå¯â âπ

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("ë´âπÇæÇÊÅI");
        if (collision.gameObject.CompareTag("Floor"))
        {
            audioSource.PlayOneShot(FootWalkSE);
        }
    }
}
