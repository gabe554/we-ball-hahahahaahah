using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] float enemyHealth, maxHealth = 3;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
         enemyHealth = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction  = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }


}
