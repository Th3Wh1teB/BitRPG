using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour, Interactable
{
    private Animator animator;
    private new Collider2D collider;

    private bool isOpen = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
        collider = GetComponent<BoxCollider2D>();
    }


    public void Open()
    {
        animator.Play("Open");
        collider.enabled = false;   
        isOpen = true; 
    }

    public void Close()
    {
        animator.Play("Close");
        collider.enabled = true;
        isOpen = false;
        

    }
    public void Toggle()
    {
        if(isOpen) Close();
        else Open();
        

    }
    public void Interact()
    {
        Toggle();
    }



}
