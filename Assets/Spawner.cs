using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

     float nextPipeTime;
    public float spawnInterval = 1;
    public float randomHeight = 1;

    private void Update()
    {
        if (Time.time > nextPipeTime)
        {
            var pos = transform.position;
            pos += Vector3.up * Random.Range(-randomHeight, randomHeight);

            Instantiate(prefab,pos,Quaternion.identity);
            nextPipeTime += spawnInterval;
        }
    }

}
