using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject key;

    public void DoorSet(bool set)
    {
        door.SetActive(set);
    }
    public void KeySet(bool set)
    {
        key.SetActive(set);
    }
}
