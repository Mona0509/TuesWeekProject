using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 worldPos;
    void Start()
    {
        
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(new Vector2(mousePos.x,mousePos.y));
        //transform.position = new Mathf.Clamp(worldPos,9.33f,4.86f);
        transform.position = worldPos;

        Debug.Log(worldPos);
    }
}
