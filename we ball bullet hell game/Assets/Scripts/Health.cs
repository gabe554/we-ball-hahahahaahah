using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = currentHealth;
    }

    // Update is called once per frame
    void takeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            // die
        }
    }
}
