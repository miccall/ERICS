using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1_Canvas : MonoBehaviour {

    public static Main1_Canvas instance;

    public Animator Main1_Animator;

    public ItemsInitiativeWoodenBridge itemsInitiativeWoodenBridge;

    private void Start()
    {
        instance = this;
    }

    /// <summary>
    /// 动画结束调用
    /// </summary>
    public void PlayEnd()
    {
        itemsInitiativeWoodenBridge.CanvasShake();
    }

    public void Main1_AnimatorPlay()
    {
        Main1_Animator.Play("Main1_UiImage");
    }
}
