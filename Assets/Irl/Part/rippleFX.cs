using UnityEngine;
using System.Collections;

public class rippleFX : MonoBehaviour 
{
	public GameObject rippleObj;	//涟漪实例
	int ti;		//计时器
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		ti++;
		if(ti>=5)		//每隔5帧，计时器发生作用
		{
			GameObject tempObj=Instantiate(rippleObj) as GameObject;		//复制涟漪物体
			tempObj.transform.parent=gameObject.transform;				//设置子物体
			tempObj.GetComponent<Animation>().Play();									//播放动画文件
			tempObj.transform.position=transform.position+new Vector3(Random.Range(10,-10),0,Random.Range(10,-10));//移动涟漪物体到一个随机位置
		}
	}
}
