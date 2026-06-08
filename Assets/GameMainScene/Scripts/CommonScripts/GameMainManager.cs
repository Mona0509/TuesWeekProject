using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMainManager : Singleton<GameMainManager>
{
    [SerializeField] private CanvasGroup _canvasGroup;
    private FadeManager _fadeManager;

    public override void Awake()
    {
        base.Awake();
        _fadeManager = new FadeManager();

    }
    private void Start()
    {
        _fadeManager.FadeIn(_canvasGroup);
    }
    public void NextScene(int sceneId)
    {
        _fadeManager.FadeOut(_canvasGroup, () =>
        {
            NextSceneLoad(sceneId).Forget();    // 非同期で始まる(他スクリプトが動いていても関係なく)
        });
    }
    private async UniTask NextSceneLoad(int sceneId)
    {
        await SceneManager.LoadSceneAsync(sceneId);
        _fadeManager.FadeIn(_canvasGroup);
    }
}
