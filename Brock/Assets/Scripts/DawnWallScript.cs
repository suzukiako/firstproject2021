using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DawnWallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
   
    {
        if (collision.gameObject.tag == "Ball")
        {
            PlayerController.ballExistFlag = false;
            Destroy(collision.gameObject);
        }
            
    }
}
