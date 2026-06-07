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
    [SerializeField] private TextMeshProUGUI text;
    private void InventoryFlag()
    {

    }
    private void IsBearFlag()
    {
        switch (itemTypes)
        {
            case ItemTyoe.None:
                text.text = "不満そうだ";
                break;
            case ItemTyoe.HeadPhone:
                text.text = "音がでないようだ";
                break;
            case ItemTyoe.Phone:
                text.text = "満足そうだ";
                break;
        }
    }
    private void IsExitFlag()
    {
        switch (itemTypes)
        {
            case ItemTyoe.None:
                text.text = "開かない";
                break;
            case　ItemTyoe.Key:
                text.text = "鍵を使った\n扉が開いた";
                break;
        }
    }
}
