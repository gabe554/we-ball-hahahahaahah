using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image[] hearts;

    public int maxHealth = 3;
    public int health;
    public Sprite Heart;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        for (int i = 0; i < hearts.Length; i++)
        {


            if (i < health)
            {
                hearts[i].sprite = Heart;
            }
            else
            {
                Destroy(hearts[i]);
            }

            if (i <= maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }


    }
    public void takeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            SceneManager.LoadScene("dead as hell");
            logicScript.playerScore = 0;
        }
    }
}
