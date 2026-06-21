using Cysharp.Threading.Tasks;
using UnityEngine;

public class BulleCreate : MonoBehaviour
{
    [SerializeField] private GameObject bulle_Red;

    private bool isCreat = false;
    private float rotationZ = 0;
    private Vector3 moveDir;
    [SerializeField] private float speed;

    void Start()
    {
        moveDir = transform.right;
    }

    public async UniTask CreatPrefab()
    {
        isCreat = true;
        if (rotationZ > 190) rotationZ = 0;
        Instantiate(
            bulle_Red,
            transform.position,
            Quaternion.Euler(0, 0, rotationZ)
        );
        rotationZ += 10;
        await UniTask.Delay(1000);
        isCreat = false;
    }

    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        if (isCreat) return;

        CreatPrefab().Forget();
    }

}
