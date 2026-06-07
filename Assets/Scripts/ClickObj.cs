using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;


public class ClickObj : MonoBehaviour
{
    [Label("クリック時に表示される画像")]
    [SerializeField] private List<Image> images;
    [SerializeField] private Button button;

    private void Start()
    {
        for (int i = 0; i < images.Count; i++) 
        {
            images[i].enabled = false;
        }
    }
    public void OnClickPhone()
    {
    }
    public void OnClickButton()
    {
        images[1].enabled = true;
    }
    public void OnClickHeadphone()
    {
        images[1].enabled = false;
        // ヘッドホン取得
        FlagCheck.inventory.Add(Inventory.HeadPhone);
        Destroy(button);
    }
    private void OnClickBear()
    {
        images[0].enabled = true;
    }
    public void OnClickExit()
    {
        for (int i = 0; i < images.Count; i++)
        {
            images[i].enabled = false;
        }
    }
}
