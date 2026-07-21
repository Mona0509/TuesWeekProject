using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    //private Transform goalObj;
    [SerializeField] private LayerMask GoalLayer;
    [HideInInspector] public int isGoal = 0;
    private void Start()
    {
        //goalObj = GameObject.FindGameObjectWithTag("Goal").GetComponent<Transform>();
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.right, GoalLayer);

        Debug.Log(hit);

        if (Input.GetKeyDown(KeyCode.Space) && hit)
        {
            isClear();
        }
    }
    private void isClear()
    {
        if(isGoal <= 2)
        {
            Destroy(gameObject);
            GameManager.Instance.score = 5.0f * GameManager.Instance.combo;
            GameManager.Instance.combo += 0.1f;
        }
        else
        {
            ClickMiss();
            Destroy(gameObject);
        }
    }
    private void ClickMiss()
    {
        GameManager.Instance.combo = 1.0f;
    }
}
