using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int sec = 0;
    private int min = 0;
    private Text timerText;

    void Start()
    {
        timerText = GameObject.Find("timer").GetComponent<Text>();
        StartCoroutine(TimeFlow());
    }
    
    IEnumerator TimeFlow()
    {
        while (true)
        {
            if (sec == 59)
            {
                min++;
                sec = -1;
            }
            sec ++;
            timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
}
