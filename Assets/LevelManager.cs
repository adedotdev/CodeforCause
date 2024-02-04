using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public bool obstacleCollision = false;
    public bool trophyReached = false;
    public bool isRunning = false;
    public bool previousIsRunning = false;
    public bool newGame = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (newGame) {
            newGame = false;
        }
        newGame = !previousIsRunning && isRunning;
        previousIsRunning = isRunning;

    }
}
