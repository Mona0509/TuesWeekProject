using TMPro;
using UnityEngine;

public class CardCreate : MonoBehaviour
{
    [SerializeField] private GameObject cardObj;
    [SerializeField] private Transform pos;
    private TextMeshProUGUI tmp;
    private void Awake()
    {
        tmp = cardObj.GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Instantiate(cardObj, pos);
            tmp.text = Random.Range(0, 3).ToString();
        }
    }
    
    public void Create()
    {
        for(int i = 0; i < 3; i++)
        {
            Instantiate(cardObj, pos);
            tmp.text = Random.Range(CardScore.minCard, CardScore.maxCard).ToString();
        }
    }
}
