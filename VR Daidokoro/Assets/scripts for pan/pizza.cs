using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour
{
    public int a = 0;
    public Color mion = new Color(0.5660378f, 0.4771249f, 0.2055892f);
    public Color shii = new Color(0.6320754f, 0.4381341f, 0.2474635f);
    public GameObject myPrefab;


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
        if (a == 2 && collision.collider.name == "mUka")
        {
            a = 3;
            DestroyObject(collision.collider);
            Instantiate(myPrefab, new Vector3(26.274f, 8.1713f, 25.669f), Quaternion.identity);

        }
        if (a == 3 && collision.collider.name == "TestoSkalkA(Clone)")
        {
            a = 4;
            DestroyObject(collision.collider);
        }
        
        if (a == 4 && collision.collider.name == "Sauce")
        {
            a = 5;
            DestroyObject(collision.collider);
        }
        if (a == 5 && collision.collider.name == "tomatocut")
        {
            a = 6;
            DestroyObject(collision.collider);
        }
        if (a == 6 && collision.collider.name == "stecut" && collision.collider.GetComponent<MeshRenderer>().material.color == mion)
        {
            a = 7;
            DestroyObject(collision.collider);
        }
        if (a == 7 && collision.collider.name == "cucucut")
        {
            a = 8;
            DestroyObject(collision.collider);
        }
        if (a == 8 && collision.collider.name == "onioncut "  && collision.collider.GetComponent<MeshRenderer>().material.color == shii)
        {
            a = 9;
            DestroyObject(collision.collider);
        }
        if (a == 9 && collision.collider.name == "chcut")
        {
            a = 10;
            DestroyObject(collision.collider);
            gameObject.transform.localPosition = new Vector3(5.5f, -1.99f, 13.26f);
        }
    }
}
