using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TMP;
    [SerializeField] private TextMeshProUGUI scoreTextCheck;
    private List<string> scoreTextOpen = new List<string> { "miss","normal","parfect" };

    private void Awake()
    {
        GameManager.Instance.score = 0;
        GameManager.Instance.combo = 0;
    }
    public void ScoreTextUpdate(int scoreCheck)
    {
        TMP.text = GameManager.Instance.score.ToString();
        scoreTextCheck.text = scoreTextOpen[scoreCheck].ToString();
    }
}
