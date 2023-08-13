using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Elevator : MonoBehaviour
{
    //Elevator01�ŏ��̃G���x�[�^�[�AElevator02�؂�ւ���̃G���x�[�^�[
    public GameObject Elevator01;
    public GameObject Elevator02;
    public bool isElevatorSwitch;
    public GameObject SwitchGraphic;
    public GameObject SwitchDownGraphic;
    void Start()
    {
        isElevatorSwitch = false;
        SwitchDownGraphic.SetActive(false);
        SwitchGraphic.SetActive(true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        //Debug.Log("�G���x�[�^�[�؂�ւ�");
        if (collision.gameObject.CompareTag("Hasiru"))
        {
            //Debug.Log("�G���x�[�^�[�؂�ւ�");
            Elevator01.gameObject.SetActive(false);
            Elevator02.gameObject.SetActive(true);
            isElevatorSwitch = true;
            SwitchGraphic.SetActive(false);
            SwitchDownGraphic.SetActive(true);
        }
    }
}
