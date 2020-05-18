using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //add enemy movement here
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("enemy took " + damage + " damage. ");
        currentHealth -= damage;
        FindObjectOfType<AudioManager>().Play("Punch1");

        Debug.Log("Enemy at " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
            //FindObjectOfType<AudioManager>().Play("Death"); // death sound
        }
    }

    void Die()
     {
        Debug.Log("enemy died");
        Debug.Log("Enemy at " + currentHealth);
     }
}
