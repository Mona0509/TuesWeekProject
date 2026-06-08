using NaughtyAttributes;
using UnityEngine;

public class NextSceneLoader : MonoBehaviour
{
    [SerializeField, Scene] private int _nextSceneIndex;

    public void OnButtonClicked()
    {
        if(_nextSceneIndex == 0)
        {
            FlagCheck.itemTypes = ItemTyoe.None;
            FlagCheck.inventory.Clear();
            FlagCheck.inventory.Add(Inventory.Phone);
        }
        GameMainManager.Instance.NextScene(_nextSceneIndex);
    }
    public void OnButtonClicked(int nextSceneIndex)
    {
        if(_nextSceneIndex == 0)
        {
            FlagCheck.itemTypes = ItemTyoe.None;
            FlagCheck.inventory.Clear();
            FlagCheck.inventory.Add(Inventory.Phone);
        }
        GameMainManager.Instance.NextScene(nextSceneIndex);
    }
}
