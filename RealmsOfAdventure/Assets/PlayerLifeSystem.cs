using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeSystem : MonoBehaviour
{
    public int maxHealth = 3; // Set the maximum health
    private int currentHealth;

    public FadingScreenAnimator fadingScreenAnimator;

    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            HandlePlayerDeath();
        }
    }

    private void HandlePlayerDeath()
    {
        fadingScreenAnimator.StartFadeInAnimation();
    }
}
