using UnityEngine;

public class ActionTrigger : MonoBehaviour
{
    public TileMapVisibility tileMapVisibility;

    private void Start()
    {
        // Assuming the TileMapVisibility component is assigned in the inspector
        tileMapVisibility = GetComponent<TileMapVisibility>();
    }

    // Example: Call this method when your desired action occurs
    public void OnActionComplete()
    {
        tileMapVisibility.HideTileMap(); // Or ShowTileMap() if you want to show it again
    }
}