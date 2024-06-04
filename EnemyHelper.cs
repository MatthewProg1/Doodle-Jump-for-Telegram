using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelper : MonoBehaviour
{
    [SerializeField] private EnemyController enemyController;
    public void Died()
    {
        enemyController.Died(); 
    }
}
