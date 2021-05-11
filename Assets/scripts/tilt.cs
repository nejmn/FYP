using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{

    public Vector3 currentRot;
   

   
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if((Input.GetAxis("Horizontal")>.4))
        {
            transform.Rotate(0, 0, 0.3f);
        }
        if ((Input.GetAxis("Horizontal") <-.4))
        {
            transform.Rotate(0, 0, -0.3f);
        }
        if ((Input.GetAxis("Vertical") > .4))
        {
            transform.Rotate(0.3f, 0, 0);
        }
        if ((Input.GetAxis("Vertical") < -.4))
        {
            transform.Rotate(-0.3f, 0, 0);
        }
    }
}
