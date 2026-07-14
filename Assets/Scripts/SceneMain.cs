using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMain : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("MainScene");
    }
}
