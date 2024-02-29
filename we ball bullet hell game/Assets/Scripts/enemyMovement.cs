using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UI;

public class enemyMovement : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] float enemyHealth, maxHealth = 3;
    public GameObject player;
    public float speed;
    private bool dead = false;


    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        enemyHealth -= damageAmount;

        if (enemyHealth <= 0 && !dead)
        {
            if(logicScript.playerScore >= HSScore.HScore)
            {
                HSScore.HScore += 1;
            }
            
            logicScript.playerScore += 1;
            dead = true;
            Destroy(gameObject);


        }

    }

// Update is called once per frame
void Update() 
    {
        Vector2 direction  = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }


}
