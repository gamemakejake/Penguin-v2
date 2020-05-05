using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public IntReference score;
    // Start is called before the first frame update
    void Start()
    {
        score.Value = 0;
    }


}
