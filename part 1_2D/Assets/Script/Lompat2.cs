using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lompat2 : MonoBehaviour
{
    [SerializeField]
    private float gravitasi = 10f;

    [SerializeField]
    private float jumpSpeed = 5f;

    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal")
        Vector3 direction = new Vector3(horizontalInput)
        direction.y -= gravitasi;
    }

    public void Jump(InputAction.CallbackContext context)
    {

    }
}
