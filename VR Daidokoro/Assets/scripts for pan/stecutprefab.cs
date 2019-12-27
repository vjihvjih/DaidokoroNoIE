using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stecutprefab : MonoBehaviour
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
            Instantiate(myPrefab, new Vector3(27.281f, 7.448f, 24.634f), Quaternion.identity);
        }

    }


}