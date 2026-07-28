using UnityEngine;

public class NotesMove : MonoBehaviour
{
    Rigidbody2D rb;
    [HideInInspector] public int isGoal = 0;
    [HideInInspector] public bool isBreak = false;
    [SerializeField] private float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos.x -= 0.05f * speed;
        transform.position = pos;
    }

}
