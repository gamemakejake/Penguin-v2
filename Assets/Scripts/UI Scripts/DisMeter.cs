using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisMeter : MonoBehaviour
{

    public Slider disBar;

    public void SetMinDis(int disLevel)
    {
        disBar.minValue = disLevel;
        disBar.value = disLevel;
    }

    public void SetDis(int disLevel)
    {
        disBar.value = disLevel;
    }

}
