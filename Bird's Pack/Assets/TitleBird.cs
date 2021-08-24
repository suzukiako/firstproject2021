using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBird : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - 0.02f,
                transform.position.y);

        if (transform.position.x < -9.8f)
        {
            Destroy(this.gameObject);
        }
    }

}