using NaughtyAttributes;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemObjs : MonoBehaviour
{
    public ItemTyoe itemtype;
    [Label("ドラッグ可能オブジェ")]
    [SerializeField] private GameObject obj;
}
