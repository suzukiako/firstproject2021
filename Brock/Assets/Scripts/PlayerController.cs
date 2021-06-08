using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject Ball;
    [SerializeField]
    private GameObject BallPosition;

    static public bool ballExistFlag = false;

    float accel = 1000.0f;
    Rigidbody rb;
  


    // Start is called before the first frame update
    void Start()
    {
        ballExistFlag = false;
        rb = this.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * Input.GetAxis("Horizontal") * accel,
            ForceMode.Impulse);
        if (Input.GetKeyDown("space"))
        {
            if (!ballExistFlag)
            {
                Instantiate(Ball,
                BallPosition.transform.position,
                BallPosition.transform.rotation);
                ballExistFlag = true;
            }
        }
           
       
        
            
    }
}
