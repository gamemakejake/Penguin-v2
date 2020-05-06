using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSoundCull : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake() 
    {
        Destroy(this.gameObject, 5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
