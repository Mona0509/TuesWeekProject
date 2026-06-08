using NaughtyAttributes;
using System.Collections.Generic;
using System.Linq;
using TMPro;
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
    public List<GameObject> inventryItem = new List<GameObject>();

    public TextMeshProUGUI text;

    [SerializeField] private Inventory inventory;
    [SerializeField] private FlagCheck flagCheck;
    private void Start()
    {
        Debug.Log(inventryItem);
        Debug.Log(canvas);
        Debug.Log(images.Count);
        for (int i = 0; i < images.Count; i++)
        {
            images[i].enabled = false;
        }
        inventryItem[0].SetActive(false);
        inventryItem[1].SetActive(false);
        inventryItem[2].SetActive(true);
        canvas.SetActive(false);

        if (FlagCheck.inventory.Contains(Inventory.Key))
        {
            inventryItem[2].SetActive(false);
            inventryItem[1].SetActive(false);
            inventryItem[0].SetActive(true);
        }
        else
        {
            inventryItem[0].SetActive(false);
            inventryItem[1].SetActive(false);
            inventryItem[2].SetActive(true);
            FlagCheck.inventory.Add(Inventory.Phone);
        }
        if (FlagCheck.inventory.Contains(Inventory.HeadPhone))
        {
            inventryItem[1].SetActive(true);
        }

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
        text.text = "";
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
            text.text = "音楽が聞きたいようだ";
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
