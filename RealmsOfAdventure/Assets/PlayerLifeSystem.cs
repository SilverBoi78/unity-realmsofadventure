using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLifeSystem : MonoBehaviour
{
    public int maxHealth = 3; // Set the maximum health
    private int currentHealth;
    public Animator fadingLife;
    public Animator deathAnimation;

    public FadingScreenAnimator fadingScreenAnimator;

    public Image[] heartImages; // Array to hold heart image references

    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth == 0)
        {
            HandlePlayerDeath();
        }

        UpdateHearts();
    }

    public void UpdateHearts()
    {
        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < currentHealth)
                heartImages[i].enabled = true;
            else
                heartImages[i].enabled = false;
        }
    }

    private void HandlePlayerDeath()
    {
        deathAnimation.SetTrigger("Death");
        fadingLife.SetFloat("FadeIn", 1f);
        StartCoroutine(LoadMainMenu());
    }

    private IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene("Menu");
    }
}
