using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2Player : MonoBehaviour
{

    public Animation playerAnimation;
    public Material _runMat;
    // Use this for initialization
    void Start()
    {

        print(Player.instance);
        Player.instance.transform.GetChild(0).GetComponent<SpriteRenderer>().material = _runMat;
        Player.instance.PlayerAnimator.Play("Run");

        playerAnimation.Play();

        Player.playState = PlayState.Pause;

    }

    /// <summary>
    /// 玩家移动结束
    /// </summary>
    public void PlayerMoveEnd()
    {
        FadeScene.instance.FadeSceneName = "Main_3";

        FadeScene.instance.FadeToScene();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
