using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountUI : MonoBehaviour
{
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCoinCountText();
    }

    // Update is called once per frame
    public void UpdateCoinCountText()
    {
        int collectedCoins = GameManager.Instance.CollectedCoins;
        int totalCoins = GameManager.Instance.TotalCoins;

        coinText.text = "Coins: " + collectedCoins + " / " + totalCoins;
    }
    
    public void DoorOpen()
    {
        coinText.text = "DOOR OPENED! PROCEED!";
    }
}
