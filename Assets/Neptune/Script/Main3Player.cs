using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main3Player : MonoBehaviour
{

    /// <summary>
    /// 移动参数
    /// </summary>
    [HideInInspector]
    public float y;

    /// <summary>
    /// 移动速度
    /// </summary>
    public float speed;

    Vector3 cameraPostion;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player.playState == PlayState.Pause)
        {
            return;
        }

        y = Input.GetAxis("Vertical");

        y = y * speed * Time.deltaTime;

        cameraPostion = Player.instance.transform.position;

        cameraPostion.z = -10;

        Player.instance.CameraObject.transform.position = cameraPostion;

        if (y != 0 && Player.instance.x != 0)
        {
            if ((y >0 && Player.instance.x>0) || (y < 0 && Player.instance.x < 0))
            {
                Player.instance.PlayerObject.transform.GetChild(0).rotation = Quaternion.Euler(0, 0, -45);
            }
            else
            {
                Player.instance.PlayerObject.transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 45);
            }
            
        }
        else if (y != 0)
        {
            Player.instance.PlayerObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(Player.instance.x != 0)
        {
            Player.instance.PlayerObject.transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 90);
        }

        //修正左右移动位置问题
        if (Player.instance.x != 0)
        {
            Player.instance.PlayerObject.transform.localScale = new Vector3(Player.instance.PlayerObject.transform.localScale.x, -Player.instance.PlayerObject.transform.localScale.x, 1);
        }

        //玩家当前是否移动
        if (y != 0)
        {
            //转身方法
            if (y > 0)
            {
                Player.instance.PlayerObject.transform.localScale = new Vector3(Player.instance.PlayerObject.transform.localScale.x, 1, 1);
            }
            else
            {
                Player.instance.PlayerObject.transform.localScale = new Vector3(Player.instance.PlayerObject.transform.localScale.x, -1, 1);
            }

            Player.instance.PlayerObject.transform.Translate(0, y, 0);

            Player.instance.PlayerAnimator.SetBool("run", true);

           
        }
        else
        {
            if (Player.instance.x ==0)
            {
                Player.instance.PlayerAnimator.SetBool("run", false);
            }
            
        }
    }
}
