using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSlap : MonoBehaviour
{
    public IntReference disatisfaction;
    public IntReference disChange;
    public FloatReference recharge;
    private float mTime;
    public Animator mAnimation;

    private void Start() 
    {
        mTime = recharge.Value;    
    }
    private void Update() 
    {
        mTime += Time.deltaTime;

    }

    private void OnTriggerStay(Collider other) 
    {
        if (other.tag == "Biting" && mTime >= recharge.Value)
        {
            mTime = 0;
            disatisfaction.Value -= disChange.Value;
            mAnimation.SetBool("FishPressed", true);
            Invoke ("ResetFish", 2F);

        }
    }

    void ResetFish()
    {
        mAnimation.SetBool("FishPressed", false);
    }
}
