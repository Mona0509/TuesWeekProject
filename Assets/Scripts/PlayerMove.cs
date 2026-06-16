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


    private void OnTriggerStay2D(Collider2D collision)
    {
        currentTileTag = collision.tag;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentTileTag = "";
    }


    public void OnDestroyButton()
    {
        layer = layerManager.LayerDestroy(layer);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) y += 1;
        if (Input.GetKeyDown(KeyCode.S)) y -= 1;
        if (Input.GetKeyDown(KeyCode.A)) x -= 1;
        if (Input.GetKeyDown(KeyCode.D)) x += 1;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (itemManager.door.activeSelf && itemManager.key.activeSelf)
            {
                isClear = true;
            }
            if (currentTileTag == "Door")
            {
                layerManager.TryClear(isClear);
            }
            if (currentTileTag == "RedTile")
            {
                layer = layerManager.TryLayerChangeUp(layer);
            }
            if (currentTileTag == "BlueTile")
            {
                layer = layerManager.TryLayerChangeDown(layer);
            }
        }
        x = Mathf.Clamp(x, -2, 2);
        y = Mathf.Clamp(y, -2, 2);

        UpdatePosition();
    }

    void UpdatePosition()
    {
        transform.position = new Vector2(x, y);
    }
}
