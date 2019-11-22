using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onioncut : MonoBehaviour
{
          // Start is called before the first frame update

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

            transform.localPosition = new Vector3(-1.42f, -1.33f, 12f);


        }
    }

  
     
}
