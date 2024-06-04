using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private Transform playerPos;
    [SerializeField] private float speed;
    [SerializeField] private float offset;
    

    private void Update()
    {
        var target = new Vector3(transform.position.x, playerPos.position.y + offset, -10);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        levelGenerator.SpawnPlatform();
    }
}
