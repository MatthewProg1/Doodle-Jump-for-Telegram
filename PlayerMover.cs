using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float jumpForce;
    private Camera camerra;
    [SerializeField] private float speed;
    private float borderLeft;
    private float borderRight;

    [SerializeField] private int score;

    [SerializeField] private float previousY = 0;

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        camerra = Camera.main;
        borderLeft = camerra.transform.position.x - camerra.aspect * camerra.orthographicSize;
        borderRight = camerra.transform.position.x + camerra.aspect * camerra.orthographicSize;

        InvokeRepeating(nameof(UpdateScore), 0, 0.25f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopAllCoroutines();
        if(collision.gameObject.TryGetComponent<EnemyController>(out var enemy))
        {
            //died
            jumpForce = 0;
        }
        if(collision.gameObject.TryGetComponent<EnemyHelper>(out var enemyHelper))
        {
            enemyHelper.Died();
        }
        rigidbody2D.velocity= Vector3.zero;
        rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        StartCoroutine(Die());
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            var touchPos = camerra.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x > 0)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }

        }


        if(transform.position.x < borderLeft || transform.position.x > borderRight)
        {
            MirrorXPos();


        }


       
    }

    private void MirrorXPos()
    {
        transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        
    }

    private IEnumerator Die()
    {
        yield return new WaitForSeconds(2.5f);
        var best = PlayerPrefs.GetInt("SaveBestScoreDoodleTest");
        if(best < score)
        {
            PlayerPrefs.SetInt("SaveBestScoreDoodleTest", score);
        }

        SceneManager.LoadScene("Menu");
      
    }

    private void UpdateScore()
    {
        if (transform.position.y > previousY)
        { 
            score += Mathf.RoundToInt(transform.position.y - previousY) * 10;
            scoreText.text = score.ToString();
            previousY = transform.position.y;
        }
    }

    
}
