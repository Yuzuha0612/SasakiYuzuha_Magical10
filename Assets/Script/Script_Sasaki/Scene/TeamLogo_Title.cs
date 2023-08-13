using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeamLogo_Title : MonoBehaviour
{//�`�[�����S��\�������ă^�C�g���Ɉړ�����X�N���v�g�ł�
    public float fadeOutTime = 0.1f;  //�t�F�[�h�A�E�g�̊J�n�^�C�~���O(�b)
    private float nowTime = 0.0f;     //�^�C�~���O�J�E���g�p
    public GameObject panel;          //�t�F�[�h�A�E�g�p�p�l��UI�I�u�W�F�N�g
    private Image image;              //panel�̃R���|�[�l���g
    private Color color;              //panel�̃J���[�ݒ�
  //2022/12/13�ǉ��@�X�e�[�W�ԍ�������
    public int StageNumber;

    void Start()
    {
        //�t�F�[�h�A�E�g�p�̃p�����[�^�擾
        image = panel.GetComponent<Image>();
        color = image.color;
        //�ȉ��L�[���l�̏����ݒ�
        //�uSTAGE�v�Ƃ����L�[�ŁAInt�l�́uStageNumber�v��ۑ�
        PlayerPrefs.SetInt("CLEARSTAGE", StageNumber);
        PlayerPrefs.Save();
        //�uBGMVOLUME�v�Ƃ����L�[�ŁAFloat�l�́u0.5f�v��ۑ�
        PlayerPrefs.SetFloat("BGMVOLUME",0.5f);
        PlayerPrefs.Save();
        //�uSEVOLUME�v�Ƃ����L�[�ŁAFloat�l�́u1.0f�v��ۑ�
        PlayerPrefs.SetFloat("SEVOLUME", 1.0f);
        PlayerPrefs.Save();
    }

    void Update()
    {
        //deltaTime�����Z���Čo�ߎ��Ԃ��v�Z����
        nowTime += Time.deltaTime;
        //�w��̕b�����o�߂����ہA�t�F�[�h�A�E�g���ăV�[����J�ڂ���
        if (fadeOutTime < nowTime)
        {
            //�t�F�[�h�A�E�g���I�������V�[���J�ڂ�����
            if (color.a == 1.0f)
            {
                SceneManager.LoadScene("Title");
            }
            //�A���t�@�l��1�𒴉߂���ꍇ�͊ۂߍ���
            else if (color.a + Time.deltaTime > 1.0f)
            {
                color.a = 1.0f;
            }
            //�A���t�@�l�����Z����
            else
            {
                color.a += Time.deltaTime;
            }
            image.color = color;
        }
    }
    }
