using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FadingScreenAnimator : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartFadeInAnimation()
    {
        animator.SetFloat("FadeIn", 1f);
    }
}
