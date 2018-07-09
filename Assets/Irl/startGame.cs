using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour {

    public void onStartGame()
    {
        FadeScene.instance.FadeSceneName = "Main_0";
        FadeScene.instance.FadeToScene();
    }
}
