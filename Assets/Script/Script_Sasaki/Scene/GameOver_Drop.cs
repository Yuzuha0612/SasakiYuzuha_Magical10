using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Drop : MonoBehaviour
{

    public AudioClip GameOverDropSE;//������Ƃ��̌��ʉ�
    AudioSource audioSource;
    public bool isGameOver;
    //2022/11/27�ǉ��@���݂̃X�e�[�W�ԍ�
    public int StageNumber;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isGameOver = false;
    }
    //�S�[���ɂԂ�������S�[���V�[���Ɉړ�����
    private void OnCollisionEnter(Collision collision)
    {
        // �������������"Hasrtu"�^�O���t���Ă���ꍇ
        //TimeCount��GameOver_Time�����s���邽�߁AisGameOver��true�ɂ���
        if (collision.gameObject.tag == "Hasiru")
        {
            audioSource.PlayOneShot(GameOverDropSE);//�Q�[���I�[�o�[���ʉ�
            //�uSTAGE�v�Ƃ����L�[�ŁAInt�l�́uStageNumber�v��ۑ�
            PlayerPrefs.SetInt("STAGE", StageNumber);
            PlayerPrefs.Save();
            // isGameOver = true;
            FadeManager.Instance.LoadScene("GameOver", 0.6f);
        }
    }
}
