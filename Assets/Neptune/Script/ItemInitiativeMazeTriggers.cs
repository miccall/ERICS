using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInitiativeMazeTriggers : ItemsInitiativeBase
{
    public GameObject MazeUIGameObject;

    //界面点击任意键按钮
    bool MazeBool;

    /// <summary>
    /// 方便测试 记录地图出口
    /// </summary>
    public Transform developers;

    public GameObject AfterObject;
    
    //地图尽头出发时间
    public override void TheTrigger()
    {
        Player.playState = PlayState.Pause;

        MazeUIGameObject.SetActive(true);

        MazeBool = true;
    }

    // Use this for initialization
    void Start () {

        MazeBool = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (MazeBool && Input.anyKeyDown)
        {
            AfterObject.SetActive(true);
            
            Invoke("WaitAfter",1f);

            MazeBool = false;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Player.instance.gameObject.transform.position = developers.position;
        }
	}

    public void WaitAfter()
    {
        FadeScene.instance.FadeSceneName = "Main_4";

        FadeScene.instance.FadeToScene();
        
    }
}
