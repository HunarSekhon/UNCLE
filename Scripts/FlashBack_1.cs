using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlashBack_1 : MonoBehaviour {
	public Image flashBack_1;

	public AudioClip pickupSound;
	public AudioClip putAwaySound;

	// Use this for initialization
	void Start () {
		flashBack_1.enabled = false;
	}

	// Update is called once per frame
	public void ShowFlashBack () {
		flashBack_1.enabled = true;
		GetComponent<AudioSource> ().PlayOneShot (pickupSound);
	}
	public void HideNoteImage(){
		flashBack_1.enabled = false;
		GetComponent<AudioSource> ().PlayOneShot (putAwaySound);
	}
}
