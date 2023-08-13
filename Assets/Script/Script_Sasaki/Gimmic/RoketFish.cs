using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketFish : MonoBehaviour
{
    //speed ロケットフィッシュの速さ  lastposition 終点
    public float speed;
    public float startposition;
    public float lastposition;
    private Vector3 pos;
    private bool isStop = false;
    public bool isStopAbilityElevator = false;
    private bool isOptionStop = false;
    bool isStart = false;
    private GameAdministrator gameAdministrator;
    private GameObject Administrator;
    void Start()
    {
        Administrator = GameObject.FindGameObjectWithTag("Administrator");
        gameAdministrator = Administrator.GetComponent<GameAdministrator>();
        pos = transform.position;
        isStopAbilityElevator = false;
        isStart = false;
    }

    void Update()
    {
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }

        if (isStopAbilityElevator == true && isStart == true)
        {
            RoketFishMove();
        }
        else if (isStopAbilityElevator == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.F8) && isStart == true && isOptionStop == true)
        {
            isStopAbilityElevator = false;
        }
        else if (isStart == true && isOptionStop == false)
        {
            isStopAbilityElevator = true;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            isOptionStop = true;
            isStopAbilityElevator = false;
        }
        if (Input.GetKey(KeyCode.F1))
        {
            isOptionStop = false;
        }
    }
    private void RoketFishMove()
    {
        if (isStop == false)
        {
            pos.x += Time.deltaTime * speed;
            transform.position = pos;
            if (pos.x > lastposition)
            {
                isStop = true;
            }
        }
        else if (isStop == true)
        {

        }
    }
}
