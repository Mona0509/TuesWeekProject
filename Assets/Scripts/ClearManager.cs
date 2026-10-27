using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{

    [Scene]
    [SerializeField] private string clearScene;
    [SerializeField] private float countTime;

    void Start()
    {
        StartCoroutine(ClearChenge());
    }
    IEnumerator ClearChenge()
    {
        yield return new WaitForSeconds(countTime);
        SceneManager.LoadScene(clearScene);
    }
}
