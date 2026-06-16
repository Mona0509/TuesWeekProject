using UnityEngine;
using UnityEngine.SceneManagement;

public class LayerManager : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    [SerializeField] private CreateTiles createTiles;

    public int LayerDestroy(int nowLayer)
    {
        if(nowLayer <= 0) return nowLayer;
        Destroy(createTiles.layerTile[nowLayer]);
        createTiles.CreateLayer(nowLayer - 1);
        return nowLayer - 1;
    }
    public int TryLayerChangeUp(int nowLayer)
    {
        if (createTiles.layerTile[nowLayer + 1] == null) return nowLayer;
        if (nowLayer + 1 >= createTiles.layerTile.Count)
        return nowLayer; 
        createTiles.CloseLayer(nowLayer);
        createTiles.CreateLayer(nowLayer + 1);
        uiManager.layerCount++;
        uiManager.FloorCount();

        return nowLayer + 1;
    }
    public int TryLayerChangeDown(int nowLayer)
    {
        if (createTiles.layerTile[nowLayer - 1] == null) return nowLayer;
        if (nowLayer - 1 < 0)
        return nowLayer; 
        createTiles.CloseLayer(nowLayer);
        createTiles.CreateLayer(nowLayer - 1);
        uiManager.layerCount--;
        uiManager.FloorCount();
        return nowLayer - 1;
    }
    public void TryClear(bool isClear)
    {
        if (isClear)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
