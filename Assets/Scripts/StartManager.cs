using UnityEngine;

public class StartManager : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.score = 0;
        GameManager.Instance.combo = 1.0f;
    }


}
