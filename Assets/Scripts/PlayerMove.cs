using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    Vector3 vec3;
    [SerializeField] private float speed = 1;
    void Start()
    {
        
    }

    public void OnMove(InputValue value)
    {
        var axis = value.Get<Vector2>();
        vec3 = new Vector3 (axis.x, 0, axis.y);
    }

    void Update()
    {
        transform.position += vec3 * speed * Time.deltaTime;
    }
}
