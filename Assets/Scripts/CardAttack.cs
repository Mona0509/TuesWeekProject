using UnityEngine;

public class CardAttack : MonoBehaviour
{
    public void Attack(int attackPoint,GameObject obj)
    {
        CardObj cardObj = obj.GetComponent<CardObj>();
        cardObj.isAttack = true;
    }
}
