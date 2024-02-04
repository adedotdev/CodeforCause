using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // Play start music when the menu opens


    }

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            UnityEngine.Debug.Log("Hello World");
            audioSource.Play();
        }

    }
}