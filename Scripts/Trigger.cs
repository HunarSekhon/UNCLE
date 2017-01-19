using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	public AudioClip noiseSound;
	public AudioClip scareSound;
	public float scareTime = 3f;

	bool showScare = false; //private bool showscare

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			GetComponent<AudioSource>().Stop();
			GetComponent<AudioSource>().loop = false;
			GetComponent<AudioSource>().clip = scareSound;
			GetComponent<AudioSource>().Play();

			showScare = true;
		}
	}

	void Update () 
	{
		if(showScare)
		{
			scareTime -= Time.deltaTime;
			if(scareTime <= 0)
			{
				GetComponent<AudioSource>().Stop();
				GetComponent<AudioSource>().loop = true;
				GetComponent<AudioSource>().clip = noiseSound;
				GetComponent<AudioSource>().Play();

				showScare = false;
			}
		}
	}
}
