using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_ver_horizon : MonoBehaviour
{
    //speed �G���x�[�^�[�̑��� startposition �n�_ lastposition �I�_
    public float speed;
    public float startposition;
    public float lastposition;
    private Vector3 pos;
    private bool isStop = false;
    public bool isStopAbilityElevator = false;
    //2022/11/27�ǉ� �Q�[���J�n����
    bool isStart = false;


    void Start()
    {
        pos = transform.position;
        isStopAbilityElevator = false;
        isStart = false;
    }

    void Update()
    {
        //2022/11/27�ǉ� �Q�[���J�n����
        //2022/11/23�ǉ� �Q�[���J�n���� �S�ẴL�[�Ή�
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityElevator == true && isStart == true)
        {
            ElevatorMoveH();
        }
        else if (isStopAbilityElevator == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            isStopAbilityElevator = false;
        }
        else if(isStart == true)
        {
            isStopAbilityElevator = true;
        }

    }
    private void ElevatorMoveH()
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
            pos.x -= Time.deltaTime * speed;
            transform.position = pos;
            if (pos.x < startposition)
            {
                isStop = false;
            }
        }
    }
}
