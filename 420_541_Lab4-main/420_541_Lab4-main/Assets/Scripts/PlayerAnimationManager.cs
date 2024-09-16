using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    private Animator animator;
    private CharacterMovement movement;
    public void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
     public void Update()
    {
        animator.SetFloat("CharacterSpeed", movement.GetMoveSpeed());
        animator.SetBool("isFalling", !movement.isGrounded);
        if(Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }
    }
}
