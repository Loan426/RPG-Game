using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float playerSpeed = 5.0f;
    public float jumpHeight = 3.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {

        if (Input.GetButtonDown("Jump")/* && groundedPlayer*/)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        float gravity = (controller.isGrounded) ? 0 : gravityValue;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal") * playerSpeed, gravity, Input.GetAxis("Vertical") * playerSpeed);

        controller.Move(move * Time.deltaTime);

    }
    
}


