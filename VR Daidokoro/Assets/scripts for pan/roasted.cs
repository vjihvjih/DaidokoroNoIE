using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roasted : MonoBehaviour
{
    public Color ma = new Color(0.6981f, 0.6168f, 0.2601f);
    public Color onio = new Color(0.7169812f, 0.4309863f, 0f);
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnTriggerStay(Collider other)
    {

    
        if (other.GetComponent<food>().roastingtime < 0 )
        {
            if (other.gameObject.name == "stecut")
            {
                other.gameObject.GetComponent<MeshRenderer>().material.color = ma;
            }
            if (other.gameObject.name == "onioncut ")
            {
                other.gameObject.GetComponent<MeshRenderer>().material.color = onio;
            }
            print("change");
        }
        else
        {
            other.GetComponent<food>().roastingtime -= Time.deltaTime;

        }

    }

}
