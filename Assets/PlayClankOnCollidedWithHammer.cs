using UnityEngine;

public class PlayClankOnCollidedWithHammer : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hammer")
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
