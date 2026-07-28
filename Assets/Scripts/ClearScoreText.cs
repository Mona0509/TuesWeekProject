using TMPro;
using UnityEngine;

public class ClearScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI clearText;
    void Start()
    {
        clearText.text = GameManager.Instance.score.ToString();
    }

}
