using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapVisibility : MonoBehaviour
{
    public Tilemap tilemap;
	public new Collision2D collider;

    private void Start()
    {
        // Assuming the Tilemap component is assigned in the inspector
        tilemap = GetComponent<Tilemap>();
		collider = GetComponent<Collision2D>();
    }

    public void HideTileMap()
    {
        tilemap.gameObject.SetActive(false);
		collider.gameObject.SetActive(false);
    }

    public void ShowTileMap()
    {
        tilemap.gameObject.SetActive(true);
		collider.gameObject.SetActive(true);
    }
}
