using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cucucutprefab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    int a;
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
            for (a = 0; a < 5; ++a)
            {
                Instantiate(myPrefab, collision.collider.transform.position, Quaternion.identity);
            }
        }

    }


}