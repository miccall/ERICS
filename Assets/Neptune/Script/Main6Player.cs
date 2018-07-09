using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main6Player : MonoBehaviour {

    public Animation roadAnimation;

    public Animator StartPlayerAnimator;

    public Animation StartPlayerAnimation;

    public Animator Image_PlayEndAnimator;

    public Animator Image_PlayEndAnimator_2;


    // Use this for initialization
    void Start () {
        //玩家状态
        Player.playState = PlayState.Pause;

        Player.instance.PlayerAnimator.SetBool("run", true);

        Invoke("PlayerMoveEnd", 6.05f);
    }

    public void PlayerMoveEnd()
    {
        Player.instance.PlayerAnimator.SetBool("run", false);

        roadAnimation.Stop();

        StartPlayerAnimator.Play("Run");

        StartPlayerAnimation.Play();

        this.transform.localScale = new Vector3(-1, 1, 1);

        Invoke("Image_PlayEnd", 0.5f);
    }

    public void Image_PlayEnd()
    {
        Image_PlayEndAnimator.Play("Image_PlayEnd");

        Invoke("Image_PlayEnd_2", 2.5f);
    }

    public void Image_PlayEnd_2()
    {
        Image_PlayEndAnimator_2.Play("Image_PlayEnd");

    }
    

    // Update is called once per frame
    void Update () {
		
	}
}
