using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float rotationSpeed;
    private Vector2 rotation;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Kamera();
        
    }

    void Kamera()
    {
        rotation.x += Input.GetAxis("Mouse X") * rotationSpeed;
        rotation.y += Input.GetAxis("Mouse Y") * rotationSpeed;

        //Membatasi pergerakan
        rotation.y = Mathf.Clamp(rotation.y, -20, 20);

        transform.localRotation = Quaternion.Euler(rotation.y, rotation.x, 0);
    }
}
