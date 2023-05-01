using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [HideInInspector] public bool isPaused;
    [SerializeField] private KeyCode pauseButton;
    public GameObject Pause;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Cursor.lockState = false ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = false ? false : true;
            Time.timeScale = 0;
            Pause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            Pause.SetActive(false);
        }
    }

    public void Continue()
    {
        isPaused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
