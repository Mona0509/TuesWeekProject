using NaughtyAttributes;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum Inventory
{
    None,
    HeadPhone,
    Phone,
    Key
}
public enum ItemTyoe
{
    None,
    HeadPhone,
    Phone,
    Key
};

public class FlagCheck : MonoBehaviour
{
    // Flag管理
    static public ItemTyoe itemTypes = ItemTyoe.None;
    // 持ち物確認
    static public List<Inventory> inventory = new List<Inventory>();
    [Label("表示するテキスト")]
    [HideInInspector] public TextMeshProUGUI text;
    [SerializeField] private NextSceneLoader nextScene;
    public void IsExitFlag()
    {
        if (inventory.Contains(Inventory.Key))
        {
            nextScene.OnButtonClicked();
        }
    }

}
