using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed;

    public CharacterController CharacterController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Berjalan();

    }

    void Berjalan()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 jalan = new Vector3(MoveX, -1, MoveZ);

        jalan = transform.TransformDirection(jalan);

        //kode dibawah supaya kamera ke atas atau ke bawah objeknya tetap diam
        if (MoveX ==0 && MoveZ ==0) jalan = Vector3.zero;

        CharacterController.Move(jalan * MovementSpeed * Time.deltaTime);
        
    }
   
}
