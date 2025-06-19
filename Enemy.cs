using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnEnable()
    {
        if (CompareTag("Enemy"))
        {
            EnemyController.enemyCount++;
        }
    }

    private void OnDisable()
    {
        if (CompareTag("Enemy"))
        {
            EnemyController.enemyCount--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
