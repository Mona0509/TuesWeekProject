using NaughtyAttributes;
using System.Collections;
using System.Security.Principal;
using UnityEngine;

public class PrefabCreate : MonoBehaviour
{
    [Label("足場生成プレハブ")]
    [SerializeField] private GameObject prefab;
    [Label("敵生成プレハブ")]
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject destroyPrefab;
    [SerializeField] private LayerMask destroyLayer;
    [Label("足場生成時間")]
    [SerializeField] private float timer;
    [Label("敵生成時間")]
    [SerializeField] private float enmeyTimer;

    private void Start()
    {
        StartCoroutine(BlockCreate());
        StartCoroutine(EnemyCreate());
    }

    //[Button]
    IEnumerator BlockCreate()
    {
        while (true)
        {
            Instantiate(prefab, new Vector2(10f, Random.Range(-5f, 4f)), Quaternion.identity);
            yield return new WaitForSeconds(timer);
        }
    }

    IEnumerator EnemyCreate()
    {
        while (true)
        {
            Instantiate(enemyPrefab, new Vector2(10f, Random.Range(-5f, 4f)), Quaternion.identity);
            yield return new WaitForSeconds(enmeyTimer);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != destroyLayer) return;
        Destroy(collision.gameObject);
    }
}
