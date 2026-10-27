using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class TitleChenge : MonoBehaviour
{
    [Scene]
    [SerializeField] private string chengeScene;

    public void SceneChengeManager()
    {
        SceneManager.LoadScene(chengeScene);
    }
}
