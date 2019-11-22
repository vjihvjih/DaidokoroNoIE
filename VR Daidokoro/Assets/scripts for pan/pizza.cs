using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour
{
    public int a = 0;
    public Color mion = new Color(0.6981f, 0.6168f, 0.2601f);
    public Color shii = new Color(0.6320754f, 0.4381341f, 0.2474635f);



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Obsolete]
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.name == "egg")
        {
            a = 1;
            DestroyObject(collision.collider);
        }
        if (a == 1 && collision.collider.name == "Bottle")
        {
            a = 2;
            DestroyObject(collision.collider);
        }
        if (a == 2 && collision.collider.name == "Sauce")
        {
            a = 3;
            DestroyObject(collision.collider);
        }
        if (a == 3 && collision.collider.name == "tomatocut")
        {
            a = 4;
            DestroyObject(collision.collider);
        }
        if (a == 4 && collision.collider.name == "stecut" && collision.collider.GetComponent<MeshRenderer>().material.color == mion)
        {
            a = 5;
            DestroyObject(collision.collider);
        }
        if (a == 5 && collision.collider.name == "cucucut ")
        {
            a = 6;
            DestroyObject(collision.collider);
        }
        if (a == 6 && collision.collider.name == "onioncut ")
        {
            a = 7;
            DestroyObject(collision.collider);
        }
        if (a == 7 && collision.collider.name == "chcut")
        {
            a = 8;
            DestroyObject(collision.collider);
            gameObject.transform.localPosition = new Vector3(36.78f, 7.09f, 45.74f);
        }
    }
}
