using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float followSpeed = 3.0f;
    float pos;
    private Vector3 targetPos;

    private void Start()
    {
        targetPos = transform.position;
        pos = transform.position.y;
    }
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            targetPos = new Vector3 (hit.point.x,this.transform.position.y, hit.point.z);
        }
        transform.position = Vector3.MoveTowards(
        transform.position,
        targetPos,
        followSpeed * Time.deltaTime);

        Vector3 dir = targetPos - transform.position;

        dir.y = 0;

        Vector3 pos = transform.position;
        pos.y = 1;
        transform.position = pos;

        if (dir.sqrMagnitude > 0.001f)
        {
            transform.rotation =
                Quaternion.LookRotation(dir) * Quaternion.Euler(90, 0, 0);
        }
    }
}
