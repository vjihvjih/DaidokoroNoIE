using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frffffs : MonoBehaviour
{
    public Color oni = new Color(0.8490f, 0.7085f, 0.1882f);
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = oni;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
