using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void TextMoveDummy()
    {
        animator.SetTrigger("Move");
    }
}
