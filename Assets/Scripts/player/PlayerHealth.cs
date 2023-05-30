using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the player
    private int currentHealth; // Current health of the player

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Set the initial health to maximum
    }

    // Function to damage the player's health
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Subtract damage amount from current health

        if (currentHealth <= 0)
        {
            Die(); // If health drops to or below zero, call the Die() function
        }
    }

    // Function to heal the player's health
    public void Heal(int healAmount)
    {
        currentHealth += healAmount; // Add heal amount to current health

        // Ensure that current health does not exceed maximum health
        currentHealth = Mathf.Min(currentHealth, maxHealth);
    }

    // Function called when the player dies
    void Die()
    {
        // Perform any necessary actions when the player dies
        // For example: display game over screen, restart level, etc.
        
    }
}