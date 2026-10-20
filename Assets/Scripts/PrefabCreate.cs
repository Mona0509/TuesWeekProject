using NaughtyAttributes;
using UnityEngine;

public class PrefabCreate : MonoBehaviour
{
    [SerializeField] private GameObject prefab; // çÏê¨Ç∑ÇÈPrefab
    [SerializeField] private GameObject destroyPrefab;
    [SerializeField] private LayerMask destroyLayer;

    [Button]
    private void BlockCreate()
    {
        Instantiate(prefab, new Vector2(10f, Random.Range(-5f, 4f)), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != destroyLayer) return;
        Destroy(collision.gameObject);
    }
}
