using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguTimeStoppingParticle : MonoBehaviour
{
    //ParticleSystem.ShapeModule SiguTimeStoppinngInParticleSystem;
    //private float SiguTimeStippingCircle;
    //2022/11/23�ǉ� �Q�[���J�n����
    bool isStart = false;
    // ���Ԓ�~�̎��ɃV�O�ɏW�܂�G�t�F�N�g�𐧌䂷��X�N���v�g
    private Vector3 scale;
    private float Effectv;
    private float Effecth;
    //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
    private GameAdministrator gameAdministrator;
    public GameObject Administrator;
    void Start()
    {

        /* SiguTimeStoppinngInParticleSystem = GetComponent<ParticleSystem>().shape;
         SiguTimeStoppinngInParticleSystem.radius = 35;
         SiguTimeStippingCircle = 35;*/
        //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
        gameAdministrator = Administrator.GetComponent<GameAdministrator>();
    }

    void Update()
    {
        //�Q�[���J�n����
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }

       // if (gameAdministrator.GameStatus == GameAdministrator.Magical10GameStatus.Game || gameAdministrator.GameStatus == GameAdministrator.Magical10GameStatus.TimeStop)
        //{
            if (isStart == true)
            {
                //���E�L�[�̂ǂ��炩�������ꂽ�Ƃ��G�t�F�N�g������������
                if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
                {
                    if (Effecth > 0 || Effectv > 0)
                    {
                        Effecth -= 0.3f;
                        Effectv -= 0.3f;
                        this.gameObject.transform.localScale = new Vector3(Effectv, Effecth, 1.0f);
                    }
                    else if (Effecth < 0 || Effectv < 0)
                    {
                        this.gameObject.transform.localScale = new Vector3(0.0f, 0.0f, 1.0f);
                        //this.gameObject.SetActive(false);
                    }
                }
                else
                {
                    if (Effecth < 6 || Effectv < 6)
                    {
                        // this.gameObject.SetActive(true);
                        Effectv += 0.3f;
                        Effecth += 0.3f;
                        //���E�L�[�̂ǂ��炩�������ꂽ�Ƃ��G�t�F�N�g��傫������
                        this.gameObject.transform.localScale = new Vector3(Effectv, Effecth, 1.0f);
                    }
                    else if (Effecth > 6 || Effectv > 6)
                    {

                    }
                }
            }
        }// else
        //{

        //}
        /* SiguTimeStoppinngInParticleSystem.radius= SiguTimeStippingCircle;
         if(SiguTimeStippingCircle>1)
         {
             SiguTimeStippingCircle--;
         }else if(SiguTimeStippingCircle<1)
         {

         }*/
    //}
}
