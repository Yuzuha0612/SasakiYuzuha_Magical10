using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TimeStoppinEffect : MonoBehaviour
{
    public PostProcessVolume TimeStopPostProcessVolume;
    private ColorGrading TimeStopPostProcessColorGrading;
    //2023/2/22追加　ゲームマネージャー取得
    private GameAdministrator gameAdministrator;
    void Start()
    {
        //TimeStopPostProcessVolume.enabled = false;
        //TimeStopPostProcessColorGrading.enabled = false;
        //TimeStopPostProcessColorGrading.saturation.value = 0.0f;
        GameObject Administrator1 = GameObject.FindGameObjectWithTag("Administrator");
        gameAdministrator = Administrator1.GetComponent<GameAdministrator>();
    }

    void Update()
    {

       
            foreach (PostProcessEffectSettings item in TimeStopPostProcessVolume.profile.settings)
            {
                if (item as ColorGrading)
                {
                    TimeStopPostProcessColorGrading = item as ColorGrading;
                };
            }
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) && (Sabodon.instance.isTogeDamege))
            {
                if (TimeStopPostProcessColorGrading)
                {
                    TimeStopPostProcessColorGrading.saturation.value = -70.0f;
                }

            }
            else
            {
                if (TimeStopPostProcessColorGrading)
                {
                    TimeStopPostProcessColorGrading.saturation.value = 50.0f;
                }
            }
        }
    // エフェクトのパラメータに値を代入する
}




