using UnityEngine;
using System.Collections;

public class RippleDestroy : MonoBehaviour 
{
	public void DestroyMe()
	{
		Destroy(gameObject);	//删除自身
	}
}