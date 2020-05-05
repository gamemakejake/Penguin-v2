using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmIBit : MonoBehaviour
{
    public IntReference score;
    public IntReference disatisfaction;
    public IntReference disGain;
    public GameObject handBit;
    
    private void OnTriggerEnter(Collider other) 
    {
       if (other.tag == "Biting")
       {
           score.Value++;
           disatisfaction.Value += disGain.Value;
           Destroy(handBit);

       }   
    }
}
