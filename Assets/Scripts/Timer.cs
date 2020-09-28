using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime = 0;
    public float startingTime = 0;
    public bool timerRunning = false;
    

    [SerializeField] Text TimeCount;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (currentTime > 0)
            {
                currentTime -= 1 * Time.deltaTime;
            }
            else
            {
                    FindObjectOfType<GameManager>().EndGame();
                    currentTime = 0;
                    timerRunning = false;
                    Score.score = 0;
            }
        }

        TimeCount.text = currentTime.ToString("0");
     
    }
}
