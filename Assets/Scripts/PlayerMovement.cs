using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float speedcontrol = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0,0, forwardForce * Time.deltaTime); 

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speedcontrol * Time.deltaTime);
        }

        if (Input.GetKey("x"))
        {
            rb.AddForce(0, 0,-speedcontrol * Time.deltaTime);
        }
    }


}
