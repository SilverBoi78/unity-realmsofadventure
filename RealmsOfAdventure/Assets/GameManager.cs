using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int totalCoins = 10;
    private int collectedCoins = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
            
    }

    public void AddCoins(int amount)
    {
        collectedCoins += amount;
    }

    public bool AreAllCoinsCollected()
    {
        return collectedCoins >= totalCoins;
    }
}
