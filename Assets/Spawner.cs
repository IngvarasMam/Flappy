using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    float nextPipeTime;
    public float spawnInterval = 1;
    public float randomHeight = 1;
    void Update()
    {
        if(Time.time>nextPipeTime)
        {
            var pos = transform.position + Vector3.up*Random.Range(-randomHeight,randomHeight);
            Instantiate(prefab,pos, Quaternion.identity);
            nextPipeTime += spawnInterval;
            if (transform.position.x < -10) Destroy(gameObject);
        }
        
    }
}
