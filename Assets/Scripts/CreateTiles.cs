using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CreateTiles : MonoBehaviour
{
    [SerializeField] private ItemManager itemManager;
    public List<GameObject> layerTile;
    private bool isSet;
    public void LayerDestory(int nowLayer)
    {
        Destroy(layerTile[nowLayer]);
        layerTile[nowLayer] = null;
        CreateLayer(nowLayer - 1);
    }

    public void CloseLayer(int layer)
    {
        if (layer >= 0 && layer < layerTile.Count)
        {
            layerTile[layer].SetActive(false);
        }

        if (layer == 0)
        {
            itemManager.DoorSet(false);
        }
        else if (layer == 1)
        {
            itemManager.KeySet(false);
        }
    }


    public void CreateLayer(int layer)
    {
        if (layer >= 0 && layer < layerTile.Count)
        {
            layerTile[layer].SetActive(true);
        }

        if (layer == 0)
        {
            itemManager.DoorSet(true);
        }
        else if (layer == 1)
        {
            itemManager.KeySet(true);
        }

    }
}
