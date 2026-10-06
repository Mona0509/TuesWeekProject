
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    //private PlayerInput input
    // 出口の準備、ハイドの設定
    Vector2 value;

    void Start()
    {
        //input = GetComponent<PlayerInput>();      
    }

    void Update()
    {
        transform.position = value;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();
    }

    public void OnHyde(InputAction.CallbackContext context)
    {
        // 隠れるコマンド
    }
}
