using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiButtonAnimation : MonoBehaviour
{
    Animator anim;
    CanvasGroup canvasGroup;
    [SerializeField] private AudioSource audioOpen,audioClose;
    void Start()
    {
        anim = GetComponent<Animator>();
        canvasGroup = GetComponent<CanvasGroup>();
        
    }


    public void OnCloseButton(string nameAnim)
    {
        anim.Play(nameAnim);
        canvasGroup.blocksRaycasts = false;
        audioClose.Play();
    }
  public void OnEnterButton(string nameAnim)
    {
        anim.Play(nameAnim);
        canvasGroup.blocksRaycasts = true;
        audioOpen.Play();
    }



}
