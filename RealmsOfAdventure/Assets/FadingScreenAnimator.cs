using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingScreenAnimator : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        
    }

    public void StartFadeInAnimation()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        Animator animator = canvasGroup.GetComponent<Animator>();
        animator.SetTrigger("FadeIn");
    }
}
