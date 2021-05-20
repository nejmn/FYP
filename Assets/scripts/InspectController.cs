using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InspectController: MonoBehaviour
{
    [SerializeField] private GameObject ObjectNameBG;
    [SerializeField] private Text objectNameUI;
    [SerializeField] private float onScreenTimer;
    [SerializeField] private Text extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [HideInInspector]  public bool startTimer;
    private float timer;

    private void Start()
    {
        ObjectNameBG.SetActive(false);
        extraInfoBG.SetActive(false);
    }

    private void Update()
    {
        if(startTimer)
        {
            timer -= Time.deltaTime;
            if(timer<=0)
            {
                timer = 0;
                ClearAdditionalInfo();
                startTimer = false;
            }
        }
    }

    public void ShowName(string objectName)
    {
        ObjectNameBG.SetActive(true);
        objectNameUI.text = objectName;
    }

    public void HideName()
    {
        ObjectNameBG.SetActive(false);
        objectNameUI.text = "";
    }
    public void ShowAdditionalInfo(string newinfo)
    {
        timer = onScreenTimer;
        startTimer = true;
        extraInfoBG.SetActive(true);
        extraInfoUI.text = newinfo;
    }
   public  void ClearAdditionalInfo()
    {
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "";
    }
}

