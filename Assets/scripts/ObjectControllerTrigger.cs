using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControllerTrigger : MonoBehaviour
{

    [SerializeField] private string objectName;
    [SerializeField] private int ObjectNumber;
    [TextArea] [SerializeField] private string extraInfo;
    [SerializeField] private InspectController inspectController;
    private void OnTriggerEnter(Collider other)
    {
        inspectController.ShowAdditionalInfo(extraInfo);

    }
}
