using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractScript : MonoBehaviour {

	public float interactDistance = 5f;
	//public Image interactIcon;
	//public bool isInteracting;
	/*
	void start(){
		if (interactIcon != null) {
			interactIcon.enabled = false;
		}
	}*/
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, interactDistance))
			{
				if (hit.collider.CompareTag ("Door")) {
					DoorScript doorScript = hit.collider.transform.parent.GetComponent<DoorScript> ();
					if (doorScript == null)
						return;

					if (Storage.keys [doorScript.index] == true) {
						doorScript.ChangeDoorState ();
					}
				} else if (hit.collider.CompareTag ("Key")) {
					Storage.keys [hit.collider.GetComponent<Key> ().index] = true;
					Destroy (hit.collider.gameObject);
				} else if (hit.collider.CompareTag ("FlashBack 1")) {
					hit.collider.GetComponent<FlashBack_1> ().ShowFlashBack ();
				}
			}

		}
	}
}
