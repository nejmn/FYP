﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    [SerializeField] private Animator myDoor=null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                myDoor.Play("DoorAnimation", 0, 0.0f);
                
            }

            else if(closeTrigger)
            {
                myDoor.Play("DoorCloseAnimation", 0, 0.0f);
               
            }
        }
    }
}
