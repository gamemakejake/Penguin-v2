using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public FloatReference myTime;
    public FloatReference maxTime;
    public BoolReference gameEnd;
    public GameObject WinScreen;
    // Start is called before the first frame update
    void Start()
    {
        myTime.Value = 0;
        gameEnd.Value = false;

    }

    // Update is called once per frame
    void Update()
    {
        myTime.Value += Time.deltaTime;

        if (myTime.Value > maxTime.Value)
        {
            gameEnd.Value = true;
            EndGame();

        }

    }

    void EndGame()
    {
        if (gameEnd.Value == true)
        {
            Time.timeScale = 0f;
            WinScreen.SetActive(true);
        }
    }
}
