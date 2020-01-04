using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class so : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name =="Knife2")
        {
            Instantiate(myPrefab, collision.collider.transform.position, Quaternion.identity);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

