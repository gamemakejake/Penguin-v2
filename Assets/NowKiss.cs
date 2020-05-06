﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowKiss : MonoBehaviour
{
    public IntReference dissatisfaction;
    public IntReference dissAmount;
    bool isHit = false;
    public Rigidbody mRB;

   private void OnTriggerStay(Collider other) 
   {
       if (other.tag == "Biting" && isHit == false)
       {
           isHit = true;
           dissatisfaction.Value -= dissAmount.Value;
           mRB.AddForce(new Vector3(5, 7, 13), ForceMode.Impulse);
           Destroy(this.gameObject, 3f);

       }
   }

}