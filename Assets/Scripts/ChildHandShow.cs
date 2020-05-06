using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildHandShow : MonoBehaviour
{

    public GameObject HandArea;
    public GameObject HandParticles;
    private bool hasShown = false;
    private float mTime;
    public float cooldown = 10f;

private void OnTriggerStay(Collider other) 
{
    if (other.tag == "BiteZone" && hasShown == false)
    {
        hasShown = true;
        HandArea.SetActive(true);
        HandParticles.SetActive(true);
        //Invoke("HandsOff", 5f);

    }
}

void HandsOff()
{
    HandArea.SetActive(false);
    HandParticles.SetActive(false);
}

private void Update() 
{
    if (hasShown == true)
    {
        mTime += Time.deltaTime;

        if (mTime >= cooldown)
        {
            hasShown =false;
        }
    }    
}

}
