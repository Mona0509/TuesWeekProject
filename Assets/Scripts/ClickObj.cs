using NaughtyAttributes;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class ClickObj : MonoBehaviour
{
    [Label("クリック時に表示される画像")]
    [SerializeField] private List<Image> images;
    [SerializeField] private Button button;
    [Label("canvas表示")]
    [SerializeField] private GameObject canvas;
    [Label("手持ちアイテム表示")]
    public List<GameObject> inventryItem;

    [SerializeField] private Inventory inventory;
    [SerializeField] private FlagCheck flagCheck;

    private void Start()
    {
        for (int i = 0; i < images.Count; i++) 
        {
            images[i].enabled = false;
        }
        inventryItem[0].SetActive(false);
        inventryItem[1].SetActive(false);
        inventryItem[2].SetActive(true);
        canvas.SetActive(false);
    }
    public void OnClickButton()
    {
        canvas.SetActive(true);
        images[1].enabled = true;
    }
    public void OnClickHeadphone()
    {
        canvas.SetActive(true);
        images[1].enabled = true;
        flagCheck.text.text = "";
    }
    public void OnUpClickHeadphone()
    {
        images[1].enabled = false;
        // ヘッドホン取得
        FlagCheck.inventory.Add(Inventory.HeadPhone);
        inventryItem[1].SetActive(true);
        Destroy(button);
        canvas.SetActive(false);
    }
    public void OnClickBear()
    {
        canvas.SetActive(true);
        images[0].enabled = true;
        if (FlagCheck.itemTypes == ItemTyoe.None)
        {
            flagCheck.text.text = "音楽が聞きたいようだ";
        }
    }
    public void OnClickExit()
    {
        canvas.SetActive(false);
        for (int i = 0; i < images.Count; i++)
        {
            images[i].enabled = false;
        }
    }
}
