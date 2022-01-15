using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 200f;
    float horizontalMove = 0f;
    bool jump = false;
    public Animator animator;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("speed", Mathf.Abs(horizontalMove)); 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        
    }
    void FixedUpdate()
    {
       controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
       jump = false;
      
    }
    public void OnLading()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("Bonus", false);
    }
}
