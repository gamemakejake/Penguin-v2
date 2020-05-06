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
    public GameObject mLight;
    public GameObject slapSound;

    private void Start() 
    {
        mTime = recharge.Value;    
    }
    private void Update() 
    {
        mTime += Time.deltaTime;
        if (mTime >= recharge.Value)
        {
            mLight.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other) 
    {

        if (other.tag == "Biting" && mTime >= recharge.Value && disatisfaction.Value >= disChange.Value)
        {
            mTime = 0;
            disatisfaction.Value -= disChange.Value;
            mAnimation.SetBool("FishPressed", true);
            slapSound.SetActive(true);
            Invoke ("ResetFish", 2F);

        }
    }

    void ResetFish()
    {
        mAnimation.SetBool("FishPressed", false);
        mLight.SetActive(false);
        slapSound.SetActive(false);
    }
}
