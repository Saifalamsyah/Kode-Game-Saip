using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reader_objek : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Objek ini menempel " +  collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        print("Objek ini berjalan di " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Objek ini terjatuh");
    }
}

