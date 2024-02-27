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

    public int playerScore;
    public Text scoreText;

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
            dead = true;
            Destroy(gameObject);

            // Increase player's score
            playerScore++;
            scoreText.text = playerScore.ToString();
        }
    }

// Update is called once per frame
void Update()
    {
        Vector2 direction  = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }


}
