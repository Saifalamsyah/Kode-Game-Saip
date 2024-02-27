using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    public HealthBar healthBar;

    public Animator animator;

    private CapsuleCollider collider;

    private void Awake()
    {
        collider = GetComponent<CapsuleCollider>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        healthBar.Dead += Dead;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dead()
    {
        collider.enabled = false;
        animator.SetTrigger("Dead");
    }
}
