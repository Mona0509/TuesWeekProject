using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform castle;
    [SerializeField] private float speed = 3f;

    private void Start()
    {
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<Transform>();
    }
    void Update()
    {
        Vector3 dir = (castle.transform.position - transform.position).normalized;

        transform.position += dir * speed * Time.deltaTime;

        // çÇÇ≥Çå≈íË
        Vector3 pos = transform.position;
        pos.y = 2.5f;
        transform.position = pos;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Castle"))
        {
            Destroy(gameObject);
            GameManager.hp--;
            if(GameManager.hp <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
        else if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
