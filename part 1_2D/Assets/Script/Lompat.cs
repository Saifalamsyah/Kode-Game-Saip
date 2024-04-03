using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lompat : MonoBehaviour
{
    public bool cubeIsOnTheGround = true;
    public Rigidbody rb;
    public CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && cubeIsOnTheGround) 
        { 
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            cubeIsOnTheGround = false;
            Debug.Log("Melompat");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            cubeIsOnTheGround = true;
        }
    }
}
