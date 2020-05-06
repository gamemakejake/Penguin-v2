using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmIBit : MonoBehaviour
{
    public IntReference score;
    public IntReference disatisfaction;
    public IntReference disGain;
    public GameObject handBit;
    public GameObject bitSound;
    
    private void OnTriggerEnter(Collider other) 
    {
       if (other.tag == "Biting")
       {
           score.Value++;
           disatisfaction.Value += disGain.Value;
           Instantiate(bitSound, transform.position, transform.rotation);
           Destroy(handBit);

       }   
    }
}
