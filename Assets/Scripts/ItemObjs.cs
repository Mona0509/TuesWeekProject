using NaughtyAttributes;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemObjs : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Inventory inventory;
    [Label("ドラッグ可能オブジェ")]
    [SerializeField] private GameObject obj;

    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} / ID:{gameObject.GetInstanceID()}");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    }
}
