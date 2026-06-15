using UnityEngine;
using UnityEngine.SceneManagement;

public class LayerManager : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    [SerializeField] private CreateTiles createTiles;
    public int TryLayerChangeUp(int nowLayer)
    {
        createTiles.CloseLayer(nowLayer);
        createTiles.CreateLayer(nowLayer + 1);
        uiManager.layerCount++;
        uiManager.FloorCount();

        return nowLayer + 1;
    }
    public int TryLayerChangeDown(int nowLayer)
    {
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
