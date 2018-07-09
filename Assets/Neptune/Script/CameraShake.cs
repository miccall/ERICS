using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // 抖动目标的transform(若未添加引用，怎默认为当前物体的transform)
    public Transform camTransform;

    //持续抖动的时长
    public float shake = 0f;

    // 抖动幅度（振幅）
    //振幅越大抖动越厉害
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;

    [HideInInspector]
    public bool shakeSwitch;

    public delegate void CameraShakeEnd();
    public event CameraShakeEnd cameraShakeEnd;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }

        shakeSwitch = false;
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        if (shakeSwitch == true)
        {
            if (shake > 0)
            {
                camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

                shake -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                shake = 0f;
                camTransform.localPosition = originalPos;

                shakeSwitch = false;

                cameraShakeEnd();

                cameraShakeEnd = null;
            }
        }

       
    }

    public void Shake(float time, ItemsInitiativeWoodenBridge shakeEnd)
    {
        shakeSwitch = true;

        shake = time;

        cameraShakeEnd += shakeEnd.End;
    }
}