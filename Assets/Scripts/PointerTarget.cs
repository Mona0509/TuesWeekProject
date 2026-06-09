using UnityEngine;

public class PointerTarget : MonoBehaviour
{
    // ポインターを発射するオブジェTransform(Player)
    [SerializeField] private Transform pointerObj;
    // ポインターをあてるターゲットTransform(Prejab)
    [SerializeField] private Transform targetObj;

    Vector2 pointerPos;
    Vector2 pointerShotPos;
    float pointerRange = 50.0f;

    // ターゲットのゲームオブジェ本体
    [SerializeField] private GameObject targetGameObject;
    // ターゲットのみを設定
    [SerializeField] private LayerMask targetLayer;

    private void Start()
    {
        // ポインターを発射する位置
        pointerPos = pointerObj.transform.position;
        // 発射方向
        pointerShotPos = pointerObj.transform.up;
    }
    private void PointerSet()
    {
        Physics2D.Raycast(pointerPos, pointerShotPos, pointerRange, targetLayer);
    }
}
