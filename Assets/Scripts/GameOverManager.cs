using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // ノーティンでScene指定
    void Start()
    {
        
    }

    public void CallSceneChenge()
    {
        SceneManager.LoadScene("");
    }
}
