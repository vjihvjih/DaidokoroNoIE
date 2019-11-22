using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatobutcheese : MonoBehaviour
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
        if (collision.collider.name== "Knife2")
        {
            transform.localPosition = new Vector3(27.99f, 7.86f, 43.59f);
        }
    }
}
