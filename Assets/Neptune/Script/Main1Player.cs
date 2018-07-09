using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1Player : MonoBehaviour
{

    public void Main1PlayerMoveEnd()
    {
        FadeScene.instance.FadeSceneName = "Main_2";

        FadeScene.instance.FadeToScene();
    }


}
