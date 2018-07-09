using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayState
{
    Idle,
    Play,
    Pause,
}

public class Player : MonoBehaviour
{

    public bool isShadowControl = true; 
        
    /// <summary>
    /// 玩家状态单例
    /// </summary>
    public static PlayState playState;
    
    /// <summary>
    /// 移动参数
    /// </summary>
    [HideInInspector]
    public float x;

    /// <summary>
    /// 玩家游戏物体
    /// </summary>
    [HideInInspector]
    public GameObject PlayerObject;

    public Animator PlayerAnimator;

    /// <summary>
    /// 移动速度
    /// </summary>
    public float speed;

    public delegate void InteractionMethods();
    public event InteractionMethods interactionMethods;

    /// <summary>
    /// 摄像机物体
    /// </summary>
    public GameObject CameraObject;

    /// <summary>
    /// 移动开关
    /// </summary>
    public static bool CameraSwitch_Life;
    public static bool CameraSwitch_Right;

    public GameObject tip;

    public static Player instance;

    Vector3 tipReversePostion;
    Vector3 tipPostion;

    private void Awake()
    {
        PlayerObject = this.gameObject;

        //玩家状态
        playState = PlayState.Idle;

        instance = this;

        tipReversePostion = new Vector3(-tip.transform.localScale.x, tip.transform.localScale.y, 1);

        tipPostion = tip.transform.localScale;

        CameraSwitch_Life = false;

        CameraSwitch_Right = false;
    }


    public void FixedUpdate()
    {
        if (playState == PlayState.Pause)
        {
            return;
        }

        x = Input.GetAxis("Horizontal");

        x = x * speed * Time.deltaTime;

        //玩家当前是否移动
        if (x != 0)
        {
            //转身方法
            if (x > 0)
            {
                PlayerObject.transform.localScale = new Vector3(1, PlayerObject.transform.localScale.y, 1);
                tip.transform.localScale = tipPostion;
                if(isShadowControl)
                    transform.GetChild(0).GetComponent<SpriteRenderer>().material.SetFloat("Vector1_1D0327F7",0);
                    
            }
            else
            {
                PlayerObject.transform.localScale = new Vector3(-1, PlayerObject.transform.localScale.y, 1);

                tip.transform.localScale = tipReversePostion;
                if(isShadowControl)
                    transform.GetChild(0).GetComponent<SpriteRenderer>().material.SetFloat("Vector1_1D0327F7",-1);
            }

            PlayerObject.transform.Translate(x, 0, 0);

            PlayerAnimator.SetBool("run", true);


            //摄像机移动方法
            if (CameraSwitch_Life && x < 0)
            {
                //print(x);
                //if (x < 0)
                //{
                CameraObject.transform.Translate(x, 0, 0);
                //}

            }
            else if (CameraSwitch_Right && x > 0)
            {
                //print(x);
                //if (x > 0)
                //{
                CameraObject.transform.Translate(x, 0, 0);
                //}
            }
        }
        else
        {
            PlayerAnimator.SetBool("run", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interactionMethods != null)
            {
                interactionMethods();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "interaction")
        {
            print("碰撞到玩家物体");

            if (collision.GetComponent<ItemsBase>() != null)
            {
                interactionMethods += collision.GetComponent<ItemsBase>().TheTrigger;
            }

            tip.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "interaction")
        {
            print("离开玩家物体");
            if (collision.GetComponent<ItemsBase>() != null)
            {
                interactionMethods -= collision.GetComponent<ItemsBase>().TheTrigger;
            }

            tip.SetActive(false);
        }
    }


}
