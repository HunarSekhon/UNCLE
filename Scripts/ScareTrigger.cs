using UnityEngine;
using System.Collections;

public class ScareTrigger : MonoBehaviour {

    public AudioSource scareAudioSource;
    public AudioClip scareSound;

    private bool hasPlayedAudio;
	
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && hasPlayedAudio == false)
        {
            scareAudioSource.PlayOneShot(scareSound);
            hasPlayedAudio = true;
        }
    }
	
}
