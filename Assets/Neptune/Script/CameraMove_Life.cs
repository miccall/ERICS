using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove_Life : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.CameraSwitch_Life = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player.CameraSwitch_Life = false;
    }

   
}
