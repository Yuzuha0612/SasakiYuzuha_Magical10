using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkiy_ver3 : MonoBehaviour
{ //speed ロボットの速さ startposition 始点 lastposition 終点
    public float speed;
    public float startposition;
    public float lastposition;
    private Vector3 pos;
    private bool isStop = false;
    private bool isStopAbilityRobot = false;
    //2022/11/27追加 ゲーム開始判定
    bool isStart = false; 
    private bool isOptionStop = false;
    void Start()
    {
        pos = transform.position;
        isStart = false;
    }

    void Update()
    {
        //2022/11/27追加 ゲーム開始判定
        //2022/11/23追加 ゲーム開始判定 全てのキー対応
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityRobot == true && isStart == true)
        {
            RobotMove();
        }
        else if (isStopAbilityRobot == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.F8) && isStart == true && isOptionStop == true)
        {
            isStopAbilityRobot = false;
        }
        else if( isStart == true && isOptionStop == false)
        {
            isStopAbilityRobot = true;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            isOptionStop = true;
            isStopAbilityRobot = false;
        }
        if (Input.GetKey(KeyCode.F1))
        {
            isOptionStop = false;
        }
    }
    private void RobotMove()
    {
        if (isStop == false)
        {
            
            pos.x += Time.deltaTime * speed;
            transform.position = pos;
            if (pos.x > lastposition)
            {
                this.transform.rotation = Quaternion.Euler(0, 120, 0);
                isStop = true;
            }
        }
        else if (isStop == true)
        {
           
            pos.x -= Time.deltaTime * speed;
            transform.position = pos;
            if (pos.x < startposition)
            {
                this.transform.rotation = Quaternion.Euler(0, 30, 0);
                isStop = false;
            }
        }
    }
}
