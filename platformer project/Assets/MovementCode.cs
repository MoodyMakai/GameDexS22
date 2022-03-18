using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AnimationModule;

public class MovementCode : MonoBehaviour
{
    public CharacterController2d controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

    bool crouch = false;

    public Animator animator;



    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if(Input.GetButtonUp("Crouch")) {
            crouch = false;
        }
        animator.SetFloat("move",0);       
    }

    void FixedUpdate(){

        controller.Move(horizontalMove*Time.fixedDeltaTime, crouch, jump);
        jump = false;





    }
}
