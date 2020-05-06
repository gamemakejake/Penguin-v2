using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreUpdate : MonoBehaviour
{
    public TMP_Text textmeshPro;
    public IntReference score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textmeshPro.text = score.Value.ToString();
    }
}
