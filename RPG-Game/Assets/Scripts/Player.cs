using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public bool isGrounded;
    public float playerSpeed = 5.0f;
    public float jumpHeight = 3.0f;
    private float gravityValue = -9.81f;
    

    public Animator animator;

    private void Start()
    {
        //animator = gameObject.GetComponent<Animator>();
        controller = gameObject.GetComponent<CharacterController>();

    }

    private void FixedUpdate()
    {

        if (Input.GetButtonDown("Jump")/* && groundedPlayer*/)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            animator.SetTrigger("Jump");

        }

        float gravity = (controller.isGrounded) ? 0 : gravityValue;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal") * playerSpeed, gravity, Input.GetAxis("Vertical") * playerSpeed);

        controller.Move(move * Time.deltaTime);

    }
   
}


