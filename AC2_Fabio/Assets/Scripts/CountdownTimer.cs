using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 30f;
    public TMP_Text timerText;
    private bool timerIsRunning = true;
    private void Start()
    {
        GameManager.Instance.PlayerMorre.AddListener(FimdeJogo);
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                GameManager.Instance.Win();
                timeRemaining = 0;
                timerIsRunning = false;
                UpdateTimerDisplay(timeRemaining);
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        timeToDisplay = Mathf.Clamp(timeToDisplay, 0, 999);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void FimdeJogo()
    {
        timerIsRunning = false;
    }

    private void OnDestroy()
    {
        GameManager.Instance.PlayerMorre?.RemoveListener(FimdeJogo);
    }
}
