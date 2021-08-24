using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdManager : MonoBehaviour
{
    [SerializeField]
    private float interval = 2;

    float nextSpawnTime;

    [SerializeField]
    GameObject[] birds;

    [SerializeField]
    GameObject spawner;

    // Update is called once per frame
    void Update()
    {
        if (nextSpawnTime < Time.timeSinceLevelLoad)
        {
            nextSpawnTime = Time.timeSinceLevelLoad + interval;
            int id = Random.Range(0, birds.Length);
            GameObject obj = (GameObject)Instantiate(birds[id],
                spawner.transform.position,
                spawner.transform.rotation);

        }
    }
}