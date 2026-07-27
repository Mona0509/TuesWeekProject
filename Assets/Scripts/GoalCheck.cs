using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    [SerializeField] private LayerMask GoalLayer;
    NotesMove notesMove;
    private void Start()
    {
        notesMove = GetComponentInParent<NotesMove>();
    }
    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && notesMove.isBreak)
        {
            isClear();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal")) 
        {
            notesMove.isGoal++;
        }
        else if (collision.CompareTag("MissAear"))
        {
            Debug.Log("ミス");
            ClickMiss();
            Destroy(transform.parent.gameObject);
        }
    }
    private void isClear()
    {
        if(notesMove.isGoal == 2)
        {
            Debug.Log("パーフェクト");
            Destroy(transform.parent.gameObject);
            GameManager.Instance.score = 5.0f * GameManager.Instance.combo;
            GameManager.Instance.combo += 0.1f;
        }
        else if (notesMove.isGoal == 1)
        {
            Debug.Log("ノーマル");
            Destroy(transform.parent.gameObject);
            GameManager.Instance.score = 2.5f * GameManager.Instance.combo;
            GameManager.Instance.combo += 0.1f;
        }
        else
        {
            Debug.Log("ミス");
            ClickMiss();
            Destroy(gameObject);
        }
    }
    private void ClickMiss()
    {
        GameManager.Instance.combo = 1.0f;
    }
}
