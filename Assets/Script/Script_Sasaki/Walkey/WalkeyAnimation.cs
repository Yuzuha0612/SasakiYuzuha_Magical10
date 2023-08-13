using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkeyAnimation : MonoBehaviour
{
    /// ウォーキーのアニメーション制御スクリプトです
    private Animator Walkeyanimator;
    private string WalkStr = "isWalk";
    bool isStart = false;
    bool isStopAbilityWalkeyAnimation = false;
    void Start()
    {
        this.Walkeyanimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityWalkeyAnimation == true && isStart == true)
        {
            this.Walkeyanimator.SetBool(WalkStr, false);
        }
        else if (isStopAbilityWalkeyAnimation == false && isStart == true)
        {
            this.Walkeyanimator.SetBool(WalkStr, true);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            isStopAbilityWalkeyAnimation = true;
        }
        else if (isStart == true)
        {
            isStopAbilityWalkeyAnimation = false;
        }
    }
}

