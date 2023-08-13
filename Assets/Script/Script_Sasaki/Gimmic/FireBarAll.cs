using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBarAll : MonoBehaviour
{//ファイアバーを回すスクリプトです
    private Transform FireBarTransform;
    public float Rotatespeed;
    bool isStart = false;
    bool isStopAbilityFireBar = false;
    bool isOptionStop = false;
    void Start()
    {
        FireBarTransform = this.transform;
    }
    void Update()
    {
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityFireBar == true && isStart == true)
        {
           FireBarRotate();
        }
        else if (isStopAbilityFireBar == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.F8) && isStart == true && isOptionStop == true)
        {
            isStopAbilityFireBar = false;
        }
        else if (isStart == true && isOptionStop == false)
        {
            isStopAbilityFireBar = true;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            isOptionStop = true;
            isStopAbilityFireBar = false;
        }
        if (Input.GetKey(KeyCode.F1))
        {
            isOptionStop = false;
        }
       
    }
    void FireBarRotate()
    {
        FireBarTransform.Rotate(0f, 0f, Rotatespeed);
    }
}
