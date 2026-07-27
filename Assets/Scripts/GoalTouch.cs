using UnityEngine;

public class GoalTouch : MonoBehaviour
{
    NotesMove notesMove;

    RaycastHit2D hit;
    GameObject notesObj;
    [SerializeField] private LayerMask notesLayer;
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.right * 10f, Color.blue);
        hit = Physics2D.Raycast(transform.position,
                                  transform.right,
                                  10.0f,
                                  notesLayer);
        notesObj = hit.transform.gameObject;

        if (hit.collider != null)
        {
            notesObj = hit.collider.gameObject;
            Debug.Log("Hit : " + notesObj.name);
        }
        else
        {
            Debug.Log("Hit‚È‚µ");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        notesMove = notesObj.GetComponent<NotesMove>();
        notesMove.isBreak = true;
    }
}
