using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed = 0.07f;
    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 direction;
    private bool isSprinting;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update() 
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        isSprinting = Input.GetKey(KeyCode.LeftShift);
        moveInput = new Vector2(x, y);
        if(moveInput.x != 0) 
        {
            direction = new Vector2(moveInput.x, 0);
        }
        else if(moveInput.y != 0)
        {
            direction = new Vector2(0, moveInput.y);
        }
        UpdateAnimation();
    }

    private void FixedUpdate()
    {
        var calculatedSpeed = speed;
        if(isSprinting == true)
        {
            calculatedSpeed *= 1.5f;
        }
        rb.MovePosition(rb.position + moveInput * calculatedSpeed);
    }


    private void UpdateAnimation()
    {
        animator.SetFloat("LookX", direction.x);
        animator.SetFloat("LookY", direction.y);
        animator.SetBool("IsMoving", moveInput != Vector2.zero);
    }
}
