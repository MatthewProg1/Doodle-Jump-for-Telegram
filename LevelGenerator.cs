using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;

    [SerializeField] private Transform lastPlatform;

    [SerializeField] private float platformDistance;


    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnPlatform();
        }
    }


    public void SpawnPlatform()
    {
        lastPlatform = Instantiate(platformPrefab, new Vector3(Random.Range(-3f, 3f), lastPlatform.position.y + platformDistance, 0), 
            Quaternion.identity).transform;
    }
}
