using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapVisibility : MonoBehaviour
{
    public Tilemap tilemap;
    public BoxCollider2D collision;

    private void Start()
    {
        // Assuming the Tilemap component is assigned in the inspector
        tilemap = GetComponent<Tilemap>();
        collision = GetComponent<BoxCollider2D>();
    }

    public void HideTileMap()
    {
        tilemap.gameObject.SetActive(false);
		collision.gameObject.SetActive(false);
    }

    public void ShowTileMap()
    {
        tilemap.gameObject.SetActive(true);
		collision.gameObject.SetActive(true);
    }
}
