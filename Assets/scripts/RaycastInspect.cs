using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RaycastInspect : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [HideInInspector] public ObjectController raycastedGO;
    [SerializeField] public Image crosshair;
    
    private bool isCrossActive;
    private bool doOnce;

    public bool DoOnce { get => doOnce; set => doOnce = value; }

    private void Update()
    {
       
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            if(hit.collider.CompareTag("InteractObject"))
            {
               
                if(!DoOnce)
                {
                    raycastedGO = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedGO.ShowObjectName();
                    CrosshairChange(true);
                }
                isCrossActive = true;
                DoOnce = true;

                if(Input.GetMouseButtonDown(0))
                {
                      raycastedGO.ShowExtraInfo();
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                   
                    raycastedGO.Interaction();
                }
            }
        }
        else
        {
            if(isCrossActive)
             {
                raycastedGO.HideObjectName();
                CrosshairChange(false);
                DoOnce = false;
             }
        }
    }

    void CrosshairChange(bool on)
    {
        if(on&& !DoOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrossActive = false;
        }
    }
    
}

