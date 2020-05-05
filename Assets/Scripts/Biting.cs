using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biting : MonoBehaviour
{
   public GameObject maw;
   public bool isMaw;

   private void Update() 
   {
       if (Input.GetButtonDown("Fire1") && isMaw == false)
       {
           isMaw = true;
           maw.SetActive(true);
           Invoke ("CloseMaw", .5f);
       }

   }

   void CloseMaw ()
   {
       isMaw = false;
       maw.SetActive(false);
   }
}
