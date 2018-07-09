using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 主动触发道具的类
/// </summary>
public class ItemsInitiativeBase : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            print("玩家主动触发碰撞物体 触发");

            //主动触发道具
            TheTrigger();
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "player")
    //    {
    //        print("玩家主动触发碰撞物体 离开");
    //    }
    //}

    public virtual void TheTrigger()
    {
    }
}
