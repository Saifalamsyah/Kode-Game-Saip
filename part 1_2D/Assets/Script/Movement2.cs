using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed = 10;
    public float rotationSpeed = 90;
    public float gravity = -20;
    public float jumpSpeed = 10;
   
    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveZ = Input.GetAxis("Vertical");

        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * moveZ;
            turnVelocity = transform.up * rotationSpeed * moveX; 

            if(Input.GetButtonDown("Jump")) 
            {
                moveVelocity.y = jumpSpeed;            
            }
        }
        //gravitasi
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}
