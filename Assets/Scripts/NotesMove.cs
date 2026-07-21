using UnityEngine;

public class NotesMove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float speed = 1.0f;
    [HideInInspector] public bool isTouchCheck = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos.x -= 0.1f /** speed*/;
        transform.position = pos;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal")) isTouchCheck = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal")) isTouchCheck = false;
    }
}
