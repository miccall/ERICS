using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScene : MonoBehaviour {

    public Animator FadeAniamtor;

    public static FadeScene instance;

    [HideInInspector]
    public string FadeSceneName;

    private void Start()
    {
        instance = this;
    }

    /// <summary>
    /// 播放切换动画
    /// </summary>
    public void FadeToScene()
    {
        FadeAniamtor.Play("Fade_Out");
    }

    /// <summary>
    /// 跳转到相对应的场景
    /// </summary>
    public void FadeSceneNameMethods()
    {
        SceneManager.LoadSceneAsync(FadeSceneName);
    }
}
