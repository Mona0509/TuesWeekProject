using System.Collections.Generic;
using UnityEngine;

public class DragAndDorpObj : MonoBehaviour
{
    List<string> objName = new List<string> 
    {
        "くま","スマホ"
    };
    private string OnDragObj()
    {
        return "くま";
    }
    public void OnDropObj(string name) // ドラッグ中のオブジェ名
    {

    }
}
