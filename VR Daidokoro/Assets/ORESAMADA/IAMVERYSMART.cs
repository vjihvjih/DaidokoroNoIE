using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAMVERYSMART : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
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
        if(collision.collider.name == "TRollingPin")
        {
            Destroy(gameObject);
            Instantiate(myPrefab, new Vector3(26.274f, 8.1713f, 25.669f), Quaternion.identity);
        }
    }
}
