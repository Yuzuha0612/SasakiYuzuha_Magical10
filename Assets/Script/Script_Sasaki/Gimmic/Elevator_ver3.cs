using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_ver3 : MonoBehaviour
{
    //speed �G���x�[�^�[�̑��� startposition �n�_ lastposition �I�_
    public float speed;
    public float startposition;
    public float lastposition;
    private Vector3 pos;
    private bool isStop = false;
    public bool isStopAbilityElevator = false;
    private bool isOptionStop = false;
    //2022/11/27�ǉ� �Q�[���J�n����
    bool isStart = false;
    //2023/2/22�ǉ��@�Q�[���}�l�[�W���[�擾
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
        //2022/11/27�ǉ� �Q�[���J�n����
        //2022/11/23�ǉ� �Q�[���J�n���� �S�ẴL�[�Ή�
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }

        if (isStopAbilityElevator == true && isStart == true)
        {
            ElevatorMove();
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
    
    private void ElevatorMove()
    {
        if (isStop == false)
        {
            pos.y += Time.deltaTime * speed;
            transform.position = pos;
            if (pos.y > lastposition)
            {
                isStop = true;
            }
        }
        else if (isStop == true)
        {
            pos.y -= Time.deltaTime * speed;
            transform.position = pos;
            if (pos.y < startposition)
            {
                isStop = false;
            }
        }
    }
}
