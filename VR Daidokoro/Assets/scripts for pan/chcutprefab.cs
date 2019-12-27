using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chcutprefab : MonoBehaviour
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
            Instantiate(myPrefab, new Vector3(21.466f, -0.114f, 25.8269f), Quaternion.identity);
        }

    }


}