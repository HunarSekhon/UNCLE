#pragma strict
var face : GameObject;

var hasplayed = false;
var entertrigger = false;

var screamingsound : AudioClip;




function Start () {

	entertrigger = false;
	face.GetComponent.<Renderer>().enabled = false;

}


function OnTriggerEnter (other : Collider) {

	entertrigger = true;
}

function Update () {

	if (entertrigger == true) {
		face.GetComponent.<Renderer>().enabled = true;
		removeovertime ();
		makehimscream ();
	
	}

}



function removeovertime () {
	yield WaitForSeconds (0.8);
	face.GetComponent.<Renderer>().enabled = false;
}


function makehimscream () {
	if (!hasplayed) {
		hasplayed = true;
		GetComponent.<AudioSource>().PlayOneShot(screamingsound);
	}
}


