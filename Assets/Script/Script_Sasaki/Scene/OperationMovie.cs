using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationMovie : MonoBehaviour
{
    public Image KeyImageRedA;
    public Image KeyImageRedD;
    public Image KeyImageRedRight;
    public Image KeyImageRedLeft;
    public Image KeyImageRedSpace;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {


            KeyImageRedD.enabled = true;
            KeyImageRedLeft.enabled = true;
        }
        else
        {
            

            KeyImageRedD.enabled = false;
            KeyImageRedLeft.enabled = false;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            KeyImageRedA.enabled = true;
            
            KeyImageRedRight.enabled = true;
            
        }
        else
        {
            KeyImageRedA.enabled = false;

            KeyImageRedRight.enabled = false;
           
        }
        if (Input.GetKey(KeyCode.Space))
        {
            KeyImageRedSpace.enabled = true;
        }
        else
        {
            KeyImageRedSpace.enabled = false;
        }
        }
}
