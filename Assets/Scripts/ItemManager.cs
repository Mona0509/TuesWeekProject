using UnityEngine;


public class ItemManager : MonoBehaviour
{
    public GameObject door;
    public GameObject key;


    public void DoorSet(bool set)
    {
        door.SetActive(set);
    }
    public void KeySet(bool set)
    {
        key.SetActive(set);
    }
}
