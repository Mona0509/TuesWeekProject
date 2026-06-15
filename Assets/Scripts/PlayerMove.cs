using NUnit.Framework.Interfaces;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    int x;
    int y;
    int layer = 0;
    [SerializeField] ItemManager itemManager;
    static public bool isClear = false;

    private string currentTileTag;
    [SerializeField] private LayerManager layerManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentTileTag = collision.tag;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentTileTag = "";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) y += 1;
        if (Input.GetKeyDown(KeyCode.S)) y -= 1;
        if (Input.GetKeyDown(KeyCode.A)) x -= 1;
        if (Input.GetKeyDown(KeyCode.D)) x += 1;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
            if(currentTileTag == "Key")
            {
                isClear = true;
                itemManager.ItemSet();
            }
            */
            if(currentTileTag == "Door")
            {
                layerManager.TryClear(isClear);
            }
            if (currentTileTag == "RedTile")
            {
                layer = layerManager.TryLayerChangeUp(layer);
            }
            else if (currentTileTag == "BlueTile")
            {
                layer = layerManager.TryLayerChangeDown(layer);
            }
        }
        UpdatePosition();
    }

    void UpdatePosition()
    {
        transform.position = new Vector3(x, y, layer);
    }
}
