using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        LevelManager.countUnlockedLevel = SceneManager.GetActiveScene().buildIndex + 1;

        Debug.Log("Поздравляем!");
        SceneManager.LoadScene("Menu");
    }



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