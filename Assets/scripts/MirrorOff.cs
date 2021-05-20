using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorOff : MonoBehaviour
{
    public GameObject Mirror;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Mirror.gameObject.SetActive(false);
        }
    }
}
