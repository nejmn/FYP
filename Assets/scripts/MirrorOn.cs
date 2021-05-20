using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorOn : MonoBehaviour
{
    public GameObject Mirror;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Mirror.gameObject.SetActive(true);
        }
    }
}
