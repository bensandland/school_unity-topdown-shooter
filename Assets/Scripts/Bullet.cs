using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDmg = 1;
    private int timeAlive;

    private void Update()
    {
        timeAlive += 1;

        if (timeAlive >= 1000)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHitReg>();

        if (enemy != null)
        {
            enemy.DamageTaken(bulletDmg);
        }
        
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
