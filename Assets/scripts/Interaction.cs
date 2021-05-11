﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Animator drawerAnim1;
    [SerializeField] private Animator drawerAnim2;
    [SerializeField] private Animator drawerAnim3;
    [SerializeField] private Animator drawerAnim4;
    [SerializeField] private Animator drawerAnim5;
    [SerializeField] private Animator drawerAnim6;
    [SerializeField] private Animator drawerAnim7;
    [SerializeField] private Animator drawerAnim8;
    [SerializeField] private Animator drawerAnim9;
    [SerializeField] private Animator drawerAnim10;
    [SerializeField] private Animator drawerAnim11;
    [SerializeField] private Animator drawerAnim12;
    [SerializeField] private Animator drawerAnim13;
    [SerializeField] private Animator drawerAnim14;
    [SerializeField] private Animator drawerAnim15;
    [SerializeField] private Animator drawerAnim16;
    [SerializeField] private Animator drawerAnim17;
    [SerializeField] private Animator drawerAnim18;
    [SerializeField] private Animator drawerAnim19;
    [SerializeField] private Animator drawerAnim20;
    [SerializeField] private Animator drawerAnim21;
    [SerializeField] private Animator drawerAnim22;
    [SerializeField] private Animator drawerAnim23;
    [SerializeField] private Animator drawerAnim24;
    [SerializeField] private Animator drawerAnim25;
    [SerializeField] private Animator drawerAnim26;
    [SerializeField] private Animator drawerAnim27;
    [SerializeField] private Animator drawerAnim29;
    [SerializeField] private Animator drawerAnim28;
    [SerializeField] private Animator drawerAnim30;
    [SerializeField] private Animator Anim31;
    [SerializeField] private Animator Anim32;
    [SerializeField] private GameObject Key;
    private bool isOpen1 = false;
    private bool isOpen2 = false;
    private bool isOpen3 = false;
    private bool isOpen4 = false;
    private bool isOpen5 = false;
    private bool isOpen6 = false;
    private bool isOpen7 = false;
    private bool isOpen8 = false;
    private bool isOpen9 = false;
    private bool isOpen10 = false;
    private bool isOpen11 = false;
    private bool isOpen12 = false;
    private bool isOpen13 = false;
    private bool isOpen14 = false;
    private bool isOpen15 = false;
    private bool isOpen16 = false;
    private bool isOpen17 = false;
    private bool isOpen18 = false;
    private bool isOpen19 = false;
    private bool isOpen20 = false;
    private bool isOpen21 = false;
    private bool isOpen22 = false;
    private bool isOpen23 = false;
    private bool isOpen24 = false;
    private bool isOpen25 = false;
    private bool isOpen26 = false;
    private bool isOpen27 = false;
    private bool isOpen28 = false;
    private bool isOpen29 = false;
    private bool isOpen30 = false;

    public AudioSource Scream;
    public GameObject Player;
    public GameObject JumpScareCamera;
    public GameObject FlashImg;
    public GameObject InspectorUI;

    public void JumpScare()
    {
        Scream.Play();
        InspectorUI.SetActive(false);
        JumpScareCamera.SetActive(true);
        Player.SetActive(false);
        FlashImg.SetActive(true);
        StartCoroutine(EndJumpScare());
    }

    IEnumerator EndJumpScare()
    {
        yield return new WaitForSeconds(2.05f);
        JumpScareCamera.SetActive(false);
        Player.SetActive(true);
        FlashImg.SetActive(false);
        InspectorUI.SetActive(true);
    }
    public void OnInteract1()
    {

        if (isOpen1 == false)
        {
            drawerAnim1.Play("opendrawer1");
            isOpen1 = true;

        }
        else
        {
            drawerAnim1.Play("closedrawer1");
            isOpen1 = false;
        }
    }
    public void OnInteract2()
    {

        if (isOpen2 == false)
        {
            drawerAnim2.Play("opendrawer2");
            isOpen2 = true;
            JumpScare();

        }
        else
        {
            drawerAnim2.Play("closedrawer2");
            isOpen2 = false;
        }
    }
    public void OnInteract3()
    {

        if (isOpen3 == false)
        {
            drawerAnim3.Play("opendrawer3");
            isOpen3 = true;
            JumpScare();
        }
        else
        {
            drawerAnim3.Play("closedrawer3");
            isOpen3 = false;
        }
    }
    public void OnInteract4()
    {

        if (isOpen4 == false)
        {
            drawerAnim4.Play("opendrawer4");
            isOpen4 = true;
            JumpScare();
        }
        else
        {
            drawerAnim4.Play("closedrawer4");
            isOpen4 = false;
        }
    }
    public void OnInteract5()
    {

        if (isOpen5 == false)
        {
            drawerAnim5.Play("opendrawer5");
            isOpen5 = true;
            JumpScare();
        }
        else
        {
            drawerAnim5.Play("closedrawer5");
            isOpen1 = false;
        }
    }
    public void OnInteract6()
    {

        if (isOpen6 == false)
        {
            drawerAnim6.Play("opendrawer6");
            isOpen6 = true;
            JumpScare();
        }
        else
        {
            drawerAnim6.Play("closedrawer6");
            isOpen6 = false;
        }
    }
    public void OnInteract7()
    {

        if (isOpen7 == false)
        {
            drawerAnim7.Play("opendrawer7");
            isOpen7 = true;
            JumpScare();
        }
        else
        {
            drawerAnim7.Play("closedrawer7");
            isOpen7 = false;
        }
    }
    public void OnInteract8()
    {

        if (isOpen8 == false)
        {
            drawerAnim8.Play("opendrawer8");
            isOpen8 = true;
            JumpScare();
        }
        else
        {
            drawerAnim8.Play("closedrawer8");
            isOpen8 = false;
        }
    }
    public void OnInteract9()
    {

        if (isOpen9 == false)
        {
            drawerAnim9.Play("opendrawer9");
            isOpen9 = true;

        }
        else
        {
            drawerAnim9.Play("closedrawer9");
            isOpen9 = false;
        }
    }
    public void OnInteract10()
    {

        if (isOpen10 == false)
        {
            drawerAnim10.Play("opendrawer10");
            isOpen10 = true;
            JumpScare();
        }
        else
        {
            drawerAnim10.Play("closedrawer10");
            isOpen10 = false;
        }
    }
    public void OnInteract11()
    {

        if (isOpen11 == false)
        {
            drawerAnim11.Play("opendrawer11");
            isOpen11 = true;
            JumpScare();
        }
        else
        {
            drawerAnim11.Play("closedrawer11");
            isOpen11 = false;
        }
    }
    public void OnInteract12()
    {

        if (isOpen12 == false)
        {
            drawerAnim12.Play("opendrawer12");
            isOpen12 = true;
            JumpScare();
        }
        else
        {
            drawerAnim12.Play("closedrawer12");
            isOpen12 = false;
        }
    }
    public void OnInteract13()
    {

        if (isOpen13 == false)
        {
            drawerAnim13.Play("opendrawer13");
            isOpen13 = true;
            JumpScare();
        }
        else
        {
            drawerAnim13.Play("closedrawer13");
            isOpen13 = false;
        }
    }
    public void OnInteract14()
    {

        if (isOpen14 == false)
        {
            drawerAnim14.Play("opendrawer14");
            isOpen14 = true;
            JumpScare();
        }
        else
        {
            drawerAnim14.Play("closedrawer14");
            isOpen14 = false;
        }
    }

    public void OnInteract15()
    {

        if (isOpen15 == false)
        {
            drawerAnim15.Play("opendrawer15");
            isOpen15 = true;
            JumpScare();
        }
        else
        {
            drawerAnim15.Play("closedrawer15");
            isOpen15 = false;
        }
    }
    public void OnInteract16()
    {

        if (isOpen16 == false)
        {
            drawerAnim16.Play("opendrawer16");
            isOpen16 = true;

        }
        else
        {
            drawerAnim16.Play("closedrawer16");
            isOpen16 = false;
        }
    }
    public void OnInteract17()
    {

        if (isOpen17 == false)
        {
            drawerAnim17.Play("opendrawer17");
            isOpen17 = true;
            JumpScare();
        }
        else
        {
            drawerAnim17.Play("closedrawer17");
            isOpen17 = false;
        }
    }
    public void OnInteract18()
    {

        if (isOpen18 == false)
        {
            drawerAnim18.Play("openrdrawer18");
            isOpen18 = true;
            JumpScare();
        }
        else
        {
            drawerAnim18.Play("closedrawer18");
            isOpen18 = false;
        }
    }
    public void OnInteract19()
    {

        if (isOpen19 == false)
        {
            drawerAnim19.Play("opendrawer19");
            isOpen19 = true;
            JumpScare();
        }
        else
        {
            drawerAnim19.Play("closedrawer19");
            isOpen19 = false;
        }
    }
    public void OnInteract20()
    {

        if (isOpen20 == false)
        {
            drawerAnim20.Play("opendrawer20");
            isOpen20 = true;
            JumpScare();
        }
        else
        {
            drawerAnim20.Play("closedrawer20");
            isOpen20 = false;
        }
    }
    public void OnInteract21()
    {

        if (isOpen21 == false)
        {
            drawerAnim21.Play("opendrawer21");
            isOpen21 = true;
            JumpScare();
        }
        else
        {
            drawerAnim21.Play("closedrawer21");
            isOpen21 = false;
        }
    }
    public void OnInteract22()
    {

        if (isOpen22 == false)
        {
            drawerAnim22.Play("opendrawer22");
            isOpen22 = true;
            JumpScare();
        }
        else
        {
            drawerAnim22.Play("closedrawer22");
            isOpen22 = false;
        }
    }
    public void OnInteract23()
    {

        if (isOpen23 == false)
        {
            drawerAnim23.Play("opendrawer23");
            isOpen23 = true;
            JumpScare();
        }
        else
        {
            drawerAnim23.Play("closedrawer23");
            isOpen23 = false;
        }
    }
    public void OnInteract24()
    {

        if (isOpen24 == false)
        {
            drawerAnim24.Play("opendrawer24");
            isOpen24 = true;

        }
        else
        {
            drawerAnim24.Play("closedrawer24");
            isOpen24 = false;
        }
    }
    public void OnInteract25()
    {

        if (isOpen25 == false)
        {
            drawerAnim25.Play("opendrawer25");
            isOpen25 = true;
            JumpScare();
        }
        else
        {
            drawerAnim25.Play("closedrawer25");
            isOpen25 = false;
        }
    }
    public void OnInteract26()
    {

        if (isOpen26 == false)
        {
            drawerAnim26.Play("opendrawer26");
            isOpen26 = true;
            JumpScare();
        }
        else
        {
            drawerAnim26.Play("closedrawer26");
            isOpen26 = false;
        }
    }
    public void OnInteract27()
    {

        if (isOpen27 == false)
        {
            drawerAnim27.Play("opendrawer27");
            isOpen27 = true;
            JumpScare();
        }
        else
        {
            drawerAnim27.Play("closedrawer27");
            isOpen27 = false;
        }
    }
    public void OnInteract28()
    {

        if (isOpen28 == false)
        {
            drawerAnim28.Play("opendrawer28");
            isOpen28 = true;
            JumpScare();
        }
        else
        {
            drawerAnim28.Play("closedrawer28");
            isOpen28 = false;
        }
    }
    public void OnInteract29()
    {

        if (isOpen29 == false)
        {
            drawerAnim29.Play("opendrawer29");
            Anim31.Play("foundkey");
            isOpen29 = true;


        }
        else
        {
            drawerAnim29.Play("closedrawer29");
            isOpen29 = false;
        }
    }
    public void OnInteract30()
    {

        if (isOpen30 == false)
        {
            drawerAnim30.Play("opendrawer30");
            isOpen30 = true;
            JumpScare();
        }
        else
        {
            drawerAnim30.Play("closedrawer30");
            isOpen30 = false;
        }
    }
    public void OnInteract31()
    {
        GameVariables.KeyCount++;

        Destroy(Key);
    }
    public void OnInteract32()
    {
        if (GameVariables.KeyCount > 0)
        {
            Anim32.Play("doorunlocked");
        }
    }
    public void OnInteract34()
    {
        SceneManager.LoadScene(3);
    }
    public void OnInteract39()
    {
        if (GameVariables.KeyCount >= 2)
        {
            Anim32.Play("doorunlocked");
        }
    }
}