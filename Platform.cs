using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private EnemyController enemyController;
    [SerializeField] private Transform spawnPos;
    private float spawnRate = 30;

    void Start()
    {
        if(Random.Range(0, 100) < spawnRate)
        {
            Instantiate(enemyController, spawnPos.position, Quaternion.identity);
        }
    }

    



}
