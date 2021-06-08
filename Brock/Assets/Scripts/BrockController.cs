using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(this.gameObject);
    }
}
