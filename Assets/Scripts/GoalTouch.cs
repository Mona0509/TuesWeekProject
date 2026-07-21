using UnityEngine;

public class GoalTouch : MonoBehaviour
{
    Collider2D collder2D;
    NotesMove notes;
    GoalCheck goalCheck;
    private void Start()
    {
        collder2D = GetComponent<Collider2D>();
        notes = GetComponentInParent<NotesMove>();
        goalCheck = GetComponentInParent<GoalCheck>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal") && notes.isTouchCheck) goalCheck.isGoal++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Goal") && notes.isTouchCheck) goalCheck.isGoal--;
    }
}
