using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Victory : MonoBehaviour
{
    public AudioSource startMusic;
    public AudioSource audioSource;
    public AudioSource backgroundMusic;
    private bool isVictory = false;
    public LevelManager levelManager;

    void Start()
    {

        levelManager.isRunning = false;
        StartGame();
    }

    void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log(collision.collider.name.ToString());
        if (collision.collider.name == "Player" && !isVictory)
        {
            isVictory = true;
            // Stop background music when victory is achieved
            backgroundMusic.Stop();
            // Play victory sound
            audioSource.Play();
            levelManager.isRunning = false;

            Invoke("StartGame", 15);
        }
    }
    void StartGame()
    {
        isVictory = false;
        // Play start music when the game starts
        startMusic.Play();

        // Schedule the background music to start after the duration of the start music
        Invoke("StartBackgroundMusic", startMusic.clip.length);

    }

    void StartBackgroundMusic()
    {
        // Start playing background music
        backgroundMusic.Play();
        levelManager.isRunning = true;
    }
}
