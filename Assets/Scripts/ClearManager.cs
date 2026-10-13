using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{
    [SerializeField] private float timer;
    [Scene]
    [SerializeField] private string clearSceneName;
    void Update()
    {
        timer -= Time.deltaTime;
        if( timer < 0)
        {
            ClearSceneChenge();
        }
    }

    private void ClearSceneChenge()
    {
        SceneManager.LoadScene(clearSceneName);
    }
}
