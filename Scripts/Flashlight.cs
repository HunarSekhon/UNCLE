using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public Light flashlight;
	public AudioSource audioSource;
	public AudioClip FlashlightOn;
	public AudioClip FlashlightOff;

	private bool isActive;

	void Start(){
		isActive = true;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			if (isActive == false) {
				flashlight.enabled = true;
				isActive = true;
				audioSource.PlayOneShot (FlashlightOn);
			} 
			else if (isActive == true) {
				flashlight.enabled = false;
				isActive = false;
				audioSource.PlayOneShot (FlashlightOff);
			}
		
		}

	}
}
