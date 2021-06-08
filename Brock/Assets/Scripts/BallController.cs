using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed = 30.0f;
    Rigidbody rb;
    
    
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce((transform.forward + transform.right) * speed,
            ForceMode.VelocityChange);
    }

}
