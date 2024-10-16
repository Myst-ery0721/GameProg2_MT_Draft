using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; 
    public string enemyTag; 

    public void SetEnemyTag(string tag)
    {
        enemyTag = tag; 
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(enemyTag))
        {
            Destroy(other.gameObject);
        }
        /*else
        {
            Destroy(gameObject);
        }*/


     
    }
}

