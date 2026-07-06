using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int hp = 5;
    private float setTime = 30.0f;

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject castle;

    [SerializeField] private float interval = 3f;

    [SerializeField] private float minX = -10f;
    [SerializeField] private float maxX = 10f;
    [SerializeField] private float minZ = -5f;
    [SerializeField] private float maxZ = 5f;


    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float x = Random.Range(minX, maxX);
            float z = Random.Range(minZ, maxZ);

            Vector3 spawnPos = new Vector3(x, 2.5f, z);

            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

            yield return new WaitForSeconds(interval);
        }
    }

    void Update()
    {
        setTime -= Time.deltaTime;
        if(setTime <= 0)
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }
}
