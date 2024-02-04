using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float elapsedTime;
    public LevelManager levelManager;

    private bool previousCollision = false;
    private bool pauseTimer = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void TimerStop() {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (levelManager.newGame)
        {
            elapsedTime = 0.0f;

        }

        if (levelManager.isRunning) 
        {
            elapsedTime += Time.deltaTime;
        }
 
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (!previousCollision && levelManager.obstacleCollision)
        {
            elapsedTime += 10;
        }

        previousCollision = levelManager.obstacleCollision;


        if (levelManager.trophyReached) 
        {
            elapsedTime = 0;
        }
    }
}
