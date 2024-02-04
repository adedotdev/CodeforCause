using UnityEngine;
using System.Collections;
using System.Diagnostics;
using TMPro;
using System;
using System.IO;
public class Victory : MonoBehaviour
{
    public AudioSource startMusic;
    public AudioSource audioSource;
    public AudioSource backgroundMusic;
    private bool isVictory = false;
    public LevelManager levelManager;
    public TextMeshProUGUI time;
    void Start()
    {
        levelManager.isRunning = false;
        StartGame();
    }

     bool IsTime1LessThanTime2(string time1, string time2)
    {
        TimeSpan ts1 = TimeSpan.ParseExact(time1, "mm\\:ss", null);
        TimeSpan ts2 = TimeSpan.ParseExact(time2, "mm\\:ss", null);
        return ts1 < ts2;
    }
    public void ToJSON(string path,string time)
    {
        string jsonContent = File.ReadAllText(path);
        if(jsonContent==""){
            File.WriteAllText(path, time);
        }
        else if (IsTime1LessThanTime2(time, jsonContent.Replace("\"", string.Empty)))
        {
            File.WriteAllText(path, time);
        }
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
            ToJSON("Assets/Scores.txt",time.text.ToString());
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
