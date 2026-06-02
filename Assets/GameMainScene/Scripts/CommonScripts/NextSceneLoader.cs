using NaughtyAttributes;
using UnityEngine;

public class NextSceneLoader : MonoBehaviour
{
    [SerializeField, Scene] private int _nextSceneIndex;

    public void OnButtonClicked()
    {
        GameMainManager.Instance.NextScene(_nextSceneIndex);
    }
}
