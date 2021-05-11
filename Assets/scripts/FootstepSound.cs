using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{


    private AudioSource Footsteps;
    [SerializeField]
    private AudioClip[] footstepClip;
    private CharacterController cc;
    private int nextUpdate = 1;
    public float volume_Min, volume_Max;
  
    void Awake()
    {
        Footsteps = GetComponent<AudioSource>();
        cc = GetComponentInParent<CharacterController>();
    }


    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            Debug.Log(Time.time + ">=" + nextUpdate);
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + 2/3;
            // Call your fonction
            UpdateEverySecond();
        }
    }
    void UpdateEverySecond()
    {
        CheckToPlay();
    }

    void CheckToPlay()
    {
        if (!cc.isGrounded)
            return;

        if (cc.velocity.sqrMagnitude > 0)
        {
           
            
                Footsteps.volume = Random.Range(volume_Min, volume_Max);
                Footsteps.clip = footstepClip[Random.Range(0, footstepClip.Length)];
                Footsteps.Play();
            
      
        }
           
    }
}
