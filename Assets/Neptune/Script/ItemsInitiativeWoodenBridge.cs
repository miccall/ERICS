using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInitiativeWoodenBridge : ItemsInitiativeBase
{
    public CameraShake cameraShake;

    public Animation playerAnimation;

    public Animator lightningAnimator;

    public Material _runmat;
    
    public override void TheTrigger()
    {
        Player.playState = PlayState.Pause;

        Main1_Canvas.instance.Main1_AnimatorPlay();       
    }

    public void CanvasShake()
    {
        cameraShake.enabled = true;

        cameraShake.Shake(1f, this);
        
        Player.instance.PlayerAnimator.Play("Idle");
        
    }

    /// <summary>
    /// 窗口抖动之后调用
    /// </summary>
    public void End()
    {
        playerAnimation.Play();

        Player.instance.PlayerAnimator.Play("Run");
        Player.instance.transform.GetChild(0).GetComponent<SpriteRenderer>().material = _runmat;
        lightningAnimator.Play("Main1_lightning_End_Jump");
    }

}
