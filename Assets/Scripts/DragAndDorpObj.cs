using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDorpObj : MonoBehaviour,IDropHandler
{
    [SerializeField] private ItemObjs itemObjs;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dragObj = eventData.pointerDrag;
        itemObjs = dragObj.GetComponent<ItemObjs>();
        FlagCheck.itemTypes = itemObjs.itemtype;

        switch (FlagCheck.itemTypes)
        {
            case ItemTyoe.HeadPhone:
                FlagCheck.itemTypes = ItemTyoe.HeadPhone;
                FlagCheck.inventory.Remove(Inventory.HeadPhone);
                break;
            case ItemTyoe.Phone:
                FlagCheck.itemTypes = ItemTyoe.Phone;
                FlagCheck.inventory.Remove(Inventory.Phone);
                FlagCheck.inventory.Add(Inventory.Key);
                break;
        }
    }
}
