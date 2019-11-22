using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formenuuuue : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*public void fjfh()
    {
        transform.localPosition = new Vector3(34.18032f, 7.36f, 30.29f);
    }*/
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h") == true)
            transform.localPosition = new Vector3(34.18032f, 7.36f, 30.29f);
    }
}
