using UnityEngine;
using System.Collections;

public class ShowText_2 : MonoBehaviour {
	public bool onTrigger;
	void OnGUI(){
		if(onTrigger)
		{
			GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to Pick Up Key");
	}
}
}