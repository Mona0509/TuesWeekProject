using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDorpObj : MonoBehaviour,IDropHandler
{
    [SerializeField] private FlagCheck flagCheck;
    [SerializeField] private ClickObj clickObj;
    [SerializeField] private ItemObjs itemObjs;
    [SerializeField] private GameObject haedPhone_Drag;
    [SerializeField] private GameObject phone_Drag;
    [SerializeField] private GameObject key_Drag;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dragObj = eventData.pointerDrag;
        itemObjs = dragObj.GetComponent<ItemObjs>();
        if(itemObjs == null || !FlagCheck.inventory.Contains(itemObjs.inventory) )
        {
            return;
        }    
        if(itemObjs.inventory == Inventory.HeadPhone)
        {
            FlagCheck.itemTypes = ItemTyoe.HeadPhone;
            FlagCheck.inventory.Remove(Inventory.HeadPhone);
            clickObj.inventryItem[1].SetActive(false);
            clickObj.text.text = "‰¹‚ª—¬‚ê‚È‚¢‚æ‚¤‚¾";
            Debug.Log("Inventory: " + string.Join(",", FlagCheck.inventory));
        }
        else if(itemObjs.inventory == Inventory.Phone)
        {
            FlagCheck.itemTypes = ItemTyoe.Phone;
            FlagCheck.inventory.Remove(Inventory.Phone);
            FlagCheck.inventory.Add(Inventory.Key);
            clickObj.inventryItem[2].SetActive(false);
            clickObj.text.text = "–ž‘«‚»‚¤‚¾";
            clickObj.inventryItem[0].SetActive(true);
            Debug.Log("Inventory: " + string.Join(",", FlagCheck.inventory));
        }
    }
}

