using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onioncut : MonoBehaviour
{
    // Start is called before the first frame update
   GameObject Avocado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Knife2")
        {
            DestroyObject(gameObject);
            foreach (Transform child in transform)
            child.position=Vector3(8.4603f, -3.724f, -3.924f);
        }
    }

    private Vector3 Vector3(float v1, float v2, float v3)
    {
        throw new NotImplementedException();
    }
}
