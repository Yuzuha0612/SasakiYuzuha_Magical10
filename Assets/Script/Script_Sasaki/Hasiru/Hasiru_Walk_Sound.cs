using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_Walk_Sound : MonoBehaviour
{
    public AudioClip FootWalkSE;//足音効果音

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
        //Debug.Log("足音だよ！");
        if (collision.gameObject.CompareTag("Floor"))
        {
            audioSource.PlayOneShot(FootWalkSE);
        }
    }
}
