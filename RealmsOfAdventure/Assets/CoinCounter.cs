using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Value of the coin (e.g., 1)
    public GameObject mobsToDestroy; // Reference to the mobs that will be destroyed

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Add coin value to player's score
            GameManager.Instance.AddCoins(coinValue);

            // Destroy the coin
            Destroy(gameObject);

            // Check if all coins are collected
            if (GameManager.Instance.AreAllCoinsCollected())
            {
                // Destroy the mobs
                Destroy(mobsToDestroy);

                // Perform any additional actions, like opening a door or transitioning to the next area
            }
        }
    }
}
