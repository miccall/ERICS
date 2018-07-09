using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main6_PlayEnd : MonoBehaviour {


    public void PlayEnd()
    {
        FadeScene.instance.FadeSceneName = "Main_End";

        FadeScene.instance.FadeToScene();
    }
}
