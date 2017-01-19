using UnityEngine;
using System.Collections;

public class Exit_2 : MonoBehaviour {

		void OnTriggerEnter (Collider other)
		{
			Application.Quit();
		}
}
