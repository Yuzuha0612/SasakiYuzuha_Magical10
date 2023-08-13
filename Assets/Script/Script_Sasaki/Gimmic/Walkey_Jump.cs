using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkey_Jump: MonoBehaviour
{
    public float  RobotJumpupSpeed;
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hasiru"))
        {
            GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
            Hasiru1.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, RobotJumpupSpeed, 0), ForceMode.VelocityChange);
        }
    }
}
