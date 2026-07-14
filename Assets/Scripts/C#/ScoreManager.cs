using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "Scriptable Objects/ScoreManager")]
public class ScoreManager : ScriptableObject
{
    // 場に出ているスコア数
    public int score;

    // 手札の合計数
    public int maxScore;

}
