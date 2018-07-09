using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeShadowDir : MonoBehaviour
{
       private Material _material;

       private void Start()
       {
              _material = GetComponent<SpriteRenderer>().material;
       }

       public void ChangeShadowDir(float i)
       {
              print("cha....");
              _material.SetFloat("Vector1_1D0327F7",i);
       }
}
