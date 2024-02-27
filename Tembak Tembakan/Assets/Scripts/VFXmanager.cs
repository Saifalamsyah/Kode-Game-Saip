using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VFXmanager : MonoBehaviour
{
    public GameObject woodImpact, bloodImpact;
    public static VFXmanager instance;

    private void Awake()
    {
        instance = this;
    }
    
}
