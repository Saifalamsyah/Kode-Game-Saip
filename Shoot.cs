using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEMBAK : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
            {
                print("Objek yang ditembak : " + hit.collider.gameObject.name);
            }
        }
    }
}
