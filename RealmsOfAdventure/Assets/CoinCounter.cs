using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Value of the coin (e.g., 1)
    
	public TileMapVisibility tileMapVisibility;
	private void Start()
	{
		tileMapVisibility = GameObject.FindObjectOfType<TileMapVisibility>();
	}
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
                tileMapVisibility.HideTileMap();
                // Perform any additional actions, like opening a door or transitioning to the next area
            }

            FindObjectOfType<CoinCountUI>().UpdateCoinCountText();
        }
    }
}
