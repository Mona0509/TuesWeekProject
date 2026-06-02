using LitMotion;
using UnityEngine;

public class FadeManager
{
    private float _fadeSpeed = 0.3f;

    public void FadeIn(CanvasGroup canvasGroup)
    {
        LMotion.Create(canvasGroup.alpha, 0, _fadeSpeed)    // Œ»Ý‚Ìalpha’l‚ð0‚É‚·‚é‚Ü‚Å‚É_fadeSpeed•bŠ|‚¯‚é
            .WithEase(Ease.Linear)  // Å‰‚©‚çÅŒã‚Ü‚Å“™‘¬‚Å•Ï‰»
            .WithOnComplete(() => canvasGroup.gameObject.SetActive(false))  // •Ï‰»‚ªI—¹‚µ‚½‚çGameObj‚ð”ñ•\Ž¦‚É‚·‚é
            .Bind(x => canvasGroup.alpha = x);
    }
    public void FadeOut(CanvasGroup canvasGroup, System.Action fadeEndCall)
    {
        canvasGroup.gameObject.SetActive(true);
        LMotion.Create(canvasGroup.alpha, 1, _fadeSpeed)    // Œ»Ý‚Ìalpha’l‚ð1‚É‚·‚é‚Ü‚Å‚É_fadeSpeed•bŠ|‚¯‚é
            .WithEase(Ease.Linear)  // Å‰‚©‚çÅŒã‚Ü‚Å“™‘¬‚Å•Ï‰»
            .WithOnComplete(() => fadeEndCall?.Invoke())
            .Bind(x => canvasGroup.alpha = x);
    }
}
