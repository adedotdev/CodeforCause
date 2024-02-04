using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WallCollisionSound : MonoBehaviour
{
    public AudioClip collisionSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            // Play collision sound when the character hits a wall
            PlayCollisionSound();
        }
    }

    void PlayCollisionSound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
