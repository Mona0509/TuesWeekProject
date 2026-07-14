using UnityEngine;

public class CardScore : MonoBehaviour
{
    public ScoreManager scoreManager;
    [SerializeField] private CardCreate create;
    [SerializeField] private CardAttack attack;
    // 場に出すカードのクリック数
    private int clickCount = 0;
    private GameObject setObj;

    // 最大値と最小値
    static public int maxCard = 3;
    static public int minCard = 1;

    bool isLastAttack = false;

    // 表
    [SerializeField] private LayerMask attackLayer;
    // 手札
    [SerializeField] private LayerMask cardLayer;


    // ターン開始
    // EventTriggerで取得する
    public void TurnStart()
    {
        // カード生成
        if (isLastAttack) return;
    }

    // カードを場に出す
    private void SetCard(GameObject obj)
    {
        clickCount++;
        if (clickCount == 2)
        {
            clickCount = 0;
            setObj = obj;
        }
    }

    // ターン終了時
    private void TurnEnd(int cardScore)
    {
        if(maxCard <= cardScore)
        {
            maxCard = cardScore;
            minCard = maxCard - 2;
        }
        attack.Attack(scoreManager.score, setObj);
    }
    private void ScoreChenge(int setNum)
    {
        scoreManager.score += setNum;
    }

}

/* 
 * はじめは1から3の数字カードのみ
 * カードを合成したときの最大上限を最大値に、これを基準に-2した数を最小値とする
 * 攻撃は一枚につき１ターン１攻撃
 * 攻撃時数字が高いほうのカードが残る
 * 攻撃対象がもつ数字分を攻撃側へマイナスする
 * 手札生成時最大上限から-2までのカードのみ生成される
 * 場のカードは一ターンに3枚のみ、出すかどうかは任意性
 * 場と同じ数字のカードを出したらプラスされる(ターン終了時に)
 * ターン終了時に場に同じカードがある場合その数に応じた数掛ける(2枚だったら×2,3枚だったら×3)
 * 自陣の場にカードが一枚もない場合手札の合計数のカードを一枚出せる(LastCard)
 * LastCardを出した場合、攻撃する以外の行動不可
 * LastCardを先に倒したほうの勝利
 */