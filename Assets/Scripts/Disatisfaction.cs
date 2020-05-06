using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disatisfaction : MonoBehaviour
{
    public IntReference disatisfaction;
    public IntReference minDis;
    public IntReference maxDis;
    public BoolReference gameOver;
    float mTime;
    public float timeDelay = 1f;
    public DisMeter disMeter; //NEW
    
    // Start is called before the first frame update
    void Start()
    {
        disatisfaction.Value = minDis.Value;
        disMeter.SetMinDis(minDis.Value); //NEW
        gameOver.Value = false;

    }

    // Update is called once per frame
    void Update()
    {
        int currentDis = (int)disatisfaction.Value; //NEW
        
        if (disatisfaction.Value < minDis.Value) disatisfaction.Value = minDis.Value;

        if (disatisfaction.Value > maxDis.Value) gameOver.Value = true;

        mTime += Time.deltaTime;

        if (mTime >= timeDelay)
        {
            disatisfaction.Value++;
            mTime = 0;

        }
        disMeter.SetDis(currentDis); //NEW
    }
}
