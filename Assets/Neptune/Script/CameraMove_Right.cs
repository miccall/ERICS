using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove_Right : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.CameraSwitch_Right = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player.CameraSwitch_Right = false;
    }
}
