using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Victory : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource backgroundMusic;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log(collision.collider.name.ToString());
        if(collision.collider.name == "Player")
        {
            backgroundMusic.Stop();
            audioSource.Play();
        }    
        
    }
}