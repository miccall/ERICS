using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsDoor : ItemsBase
{
    public GameObject OpenDoor;

    public GameObject CloseDoor;

    public string FadeSceneName;

    public override void TheTrigger()
    {
        OpenDoor.SetActive(true);

        CloseDoor.SetActive(false);

        //切换场景
        FadeScene.instance.FadeSceneName = FadeSceneName;

        FadeScene.instance.FadeToScene();

        Player.playState = PlayState.Pause;
    }

   
}
