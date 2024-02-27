using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEMBAK : MonoBehaviour
{
    public Movementcontroller movementcontroller;

    public Camera camera;

    public float demage;

    public bool canShoot = true;
    WaitForSeconds shootDelay = new WaitForSeconds(0.2f);

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
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
            
        }
        if (Input.GetMouseButtonUp(0)) 
        {
            movementcontroller.animator.SetBool("Shoot", false);
        }

        if (Input.GetMouseButton(0) && canShoot) 
        {
            StartCoroutine(shootdelaycoroutine());
            movementcontroller.animator.SetBool("Shoot", true);
            RaycastHit hit;
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
            {
                print("Objek yang ditembak : " + hit.collider.gameObject.name);
                if (hit.collider.GetComponent<HealthBar>())
                {
                    Instantiate(VFXmanager.instance.bloodImpact, hit.point, Quaternion.identity);
                    hit.collider.GetComponent<HealthBar>().Takedemage(demage);
                }
                else
                {
                    Instantiate(VFXmanager.instance.woodImpact, hit.point, Quaternion.identity);
                }
            }
        }
     
    }
    IEnumerator shootdelaycoroutine() 
    {
        canShoot = false;
        yield return shootDelay;
        canShoot =true;

    }
}
