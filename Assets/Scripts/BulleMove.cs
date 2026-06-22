using UnityEngine;

public class BulleMove : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
