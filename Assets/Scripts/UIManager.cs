using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI floorText;
    public int layerCount = 1;
    private void Start()
    {
        FloorCount();
    }
    public void FloorCount()
    {
        floorText.text = layerCount + " Floor";
    }
}
