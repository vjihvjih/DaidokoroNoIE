using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soforpref : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
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
            Destroy(gameObject);
            Instantiate(myPrefab, new Vector3(22.513f, 5.97f, 26.723f), Quaternion.identity);
        }
        
    }

    
}
