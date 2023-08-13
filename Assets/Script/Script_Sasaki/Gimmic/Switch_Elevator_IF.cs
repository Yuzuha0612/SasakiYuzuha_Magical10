using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Elevator_IF : MonoBehaviour
{//エレベーター切り替え用に急遽作ったスクリプトです
    public Collider Elevator02Collider;
    public MeshRenderer Elevator02Mesh;
    public GameObject ElevatorSwitchObject;
    public GameObject ElevatorGraphic;
    void Start()
    {
        ElevatorSwitchObject = GameObject.FindGameObjectWithTag("ElevatorSwitch");
        Elevator02Collider = GetComponent<Collider>();
         Elevator02Collider.enabled = false;
        Elevator02Mesh = GetComponent<MeshRenderer>();
        Elevator02Mesh.enabled = false;
        ElevatorGraphic.SetActive(false);
    }
    void Update()
    {
        if (ElevatorSwitchObject.GetComponent<Switch_Elevator>().isElevatorSwitch)
        {
            ElevatorSwitching();
        }
    }
     
private void ElevatorSwitching()
    {
        Elevator02Collider.enabled = true;
        Elevator02Mesh.enabled = true;
        ElevatorGraphic.SetActive(true);
    }
}
