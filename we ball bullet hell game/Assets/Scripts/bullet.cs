using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.TryGetComponent<enemyMovement>(out enemyMovement enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
