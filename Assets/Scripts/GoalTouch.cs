using UnityEngine;

public class GoalTouch : MonoBehaviour
{
    NotesMove notesMove;

    RaycastHit2D hit;
    GameObject notesObj;
    [SerializeField] private LayerMask notesLayer;
    private void Update()
    {
        hit = Physics2D.Raycast(transform.position,
                                  transform.right,
                                  10.0f,
                                  notesLayer);
        if (!hit) return;

        if (hit.collider != null)
        {
            notesObj = hit.transform.gameObject;
            notesObj = hit.collider.gameObject;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        notesMove = notesObj.GetComponent<NotesMove>();
        notesMove.isBreak = true;
    }
}
