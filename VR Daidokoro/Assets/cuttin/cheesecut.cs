using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheesecut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Knife2")
        {
            transform.localPosition = new Vector3(27.04f, 8.25f, 38.36f);
                }
    }

}
