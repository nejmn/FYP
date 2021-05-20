using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 0.8f;
    public float gravity = -9.8f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jump = 1f;
    Vector3 velocity;
    bool isGrounded;
    public AudioSource AS;

    private void Start()
    {
        AS = GetComponent<AudioSource>();

       // PlayerPrefs.SetFloat("x", 1f);
      // PlayerPrefs.SetFloat("y", 1.7f);
      // PlayerPrefs.SetFloat("z", 139f);
    }
    
   
   void Update()
    {
       
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded&&velocity.y<0)
        {
            velocity.y = -2f;
        }
        //setting input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //turning the input into a direction we want to move
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move*speed*Time.deltaTime);
        //deltaTime makes it framerate independent
        if(Input.GetButtonDown("Jump")&&isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D))
        {
            AS.mute = false;

        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            AS.mute = true;

        }
    }
}
