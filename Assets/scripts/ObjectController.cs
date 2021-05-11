using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectController : MonoBehaviour
{

    [SerializeField] private string objectName;
    [SerializeField] private int ObjectNumber;
    [TextArea] [SerializeField] private string extraInfo;
    [SerializeField] private InspectController inspectController;
    [SerializeField] private Interaction ObjectInteraction;
    [SerializeField] public bool isInteractable;
    
    public void ShowObjectName()
    {
        inspectController.ShowName(objectName);
    }

    public void HideObjectName()
    {
        inspectController.HideName();
    }
    public void ShowExtraInfo()
    {
        inspectController.ShowAdditionalInfo(extraInfo);
    }
   public void Interaction()
    {
        if (isInteractable == true)
        {
            if (ObjectNumber == 1)
            {
                ObjectInteraction.OnInteract1();
            }
            if (ObjectNumber == 2)
            {
                ObjectInteraction.OnInteract2();
            }
            if (ObjectNumber == 3)
            {
                ObjectInteraction.OnInteract3();
            }
            if (ObjectNumber == 4)
            {
                ObjectInteraction.OnInteract4();
            }
            if (ObjectNumber == 5)
            {
                ObjectInteraction.OnInteract5();
            }
            if (ObjectNumber == 6)
            {
                ObjectInteraction.OnInteract6();
            }
            if (ObjectNumber == 7)
            {
                ObjectInteraction.OnInteract7();
            }
            if (ObjectNumber == 8)
            {
                ObjectInteraction.OnInteract8();
            }
            if (ObjectNumber == 9)
            {
                ObjectInteraction.OnInteract9();
            }
            if (ObjectNumber == 10)
            {
                ObjectInteraction.OnInteract10();
            }
            if (ObjectNumber == 11)
            {
                ObjectInteraction.OnInteract11();
            }
            if (ObjectNumber == 12)
            {
                ObjectInteraction.OnInteract12();
            }
            if (ObjectNumber == 13)
            {
                ObjectInteraction.OnInteract13();
            }
            if (ObjectNumber == 14)
            {
                ObjectInteraction.OnInteract14();
            }
            if (ObjectNumber == 15)
            {
                ObjectInteraction.OnInteract15();
            }
            if (ObjectNumber == 16)
            {
                ObjectInteraction.OnInteract16();
            }
            if (ObjectNumber == 17)
            {
                ObjectInteraction.OnInteract17();
            }
            if (ObjectNumber == 18)
            {
                ObjectInteraction.OnInteract18();
            }
            if (ObjectNumber == 19)
            {
                ObjectInteraction.OnInteract19();
            }
            if (ObjectNumber == 20)
            {
                ObjectInteraction.OnInteract20();
            }
            if (ObjectNumber == 21)
            {
                ObjectInteraction.OnInteract21();
            }
            if (ObjectNumber == 22)
            {
                ObjectInteraction.OnInteract22();
            }
            if (ObjectNumber == 23)
            {
                ObjectInteraction.OnInteract23();
            }
            if (ObjectNumber == 24)
            {
                ObjectInteraction.OnInteract24();
            }
            if (ObjectNumber == 25)
            {
                ObjectInteraction.OnInteract25();
            }
            if (ObjectNumber == 26)
            {
                ObjectInteraction.OnInteract26();
            }
            if (ObjectNumber == 27)
            {
                ObjectInteraction.OnInteract27();
            }
            if (ObjectNumber == 28)
            {
                ObjectInteraction.OnInteract28();
            }
            if (ObjectNumber == 29)
            {
                ObjectInteraction.OnInteract29();
              
            }
            if (ObjectNumber == 30)
            {
                ObjectInteraction.OnInteract30();
            }
            if (ObjectNumber == 31)
            {
                ObjectInteraction.OnInteract31();
            }
            if (ObjectNumber == 32)
            {
                ObjectInteraction.OnInteract32();
            }
            if (ObjectNumber == 34)
            {
                ObjectInteraction.OnInteract34();
            }
            if (ObjectNumber == 39)
            {
                ObjectInteraction.OnInteract39();
            }
        }
        
    }
}
