using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // Play start music when the menu opens
        audioSource.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
