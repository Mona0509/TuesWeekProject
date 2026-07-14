using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Animator animator2;

    public void TextMoveDummy()
    {
        animator.SetTrigger("Move");
    }
    public void Answer()
    {
        animator2.SetTrigger("Clear");
    }
}
