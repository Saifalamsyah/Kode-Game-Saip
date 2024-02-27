using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float hp;
    public event Action Dead;
    public bool isdead;


    public float Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;

            if (hp <= 0)
            {
                isdead = true;
                Dead?.Invoke();
            }
            print("Hp Berkurang : ");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Takedemage(float dmgAmount)
    {
        if (isdead) return;
        Hp -= dmgAmount;
    }
}
