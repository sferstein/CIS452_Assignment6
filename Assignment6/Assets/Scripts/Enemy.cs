using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Enemy.cs
 * Assignment 6
 * This is the class to move the enemy.
 */

public class Enemy : MonoBehaviour
{
    public float speed;
    public float enemyHealth = 2;
    private GameObject player;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        this.transform.LookAt(player.transform);
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyHealth--;
        }
        if (collision.gameObject.CompareTag("RailBullet"))
        {
            enemyHealth = enemyHealth - 2;
        }
        if (collision.gameObject.CompareTag("ShortSword"))
        {
            enemyHealth--;
        }
        if (collision.gameObject.CompareTag("HeavySword"))
        {
            enemyHealth = enemyHealth - 2;
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
