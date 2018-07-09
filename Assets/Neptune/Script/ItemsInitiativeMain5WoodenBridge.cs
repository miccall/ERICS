using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInitiativeMain5WoodenBridge : ItemsInitiativeBase
{

	public Animation PlayerMoveAnimation;

	private bool run;
	
    public override void TheTrigger()
    {
        FadeScene.instance.FadeSceneName = "Main_6";

        FadeScene.instance.FadeToScene();

	    PlayerMoveAnimation.Play();

	    run = true;

    }

    // Use this for initialization
    void Start ()
    {
	    run = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (run)
		{
			Player.instance.PlayerAnimator.SetBool("run", true);
		}
		
	}
}
