using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickObj : MonoBehaviour
{
    [SerializeField] private List<Image> images;

    private void Start()
    {
        for (int i = 0; i < images.Count; i++) 
        {
            images[i].enabled = false;
        }
    }

    private void OnClickPhone()
    {
    }
    private void OnClickEarphone()
    {

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
