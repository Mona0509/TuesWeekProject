using Cysharp.Threading.Tasks;
using UnityEngine;

public class BulleCreate : MonoBehaviour
{
    [SerializeField] private GameObject bulle_Red;
    [SerializeField] private GameObject bulle_Blue;

    private bool isCreat = false;
    private float rotationZ = 0;
    private float rotation_Z = 0;
    private Vector3 moveDir;

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
        if (rotation_Z < -190) rotation_Z = 0;
        Instantiate(
            bulle_Blue,
            transform.position,
            Quaternion.Euler(0, 0, rotation_Z)
        );
        rotationZ += 10;
        rotation_Z -= 10;
        await UniTask.Delay(100);
        isCreat = false;
    }

    private void Update()
    {
        if (isCreat) return;

        CreatPrefab().Forget();
    }

}
