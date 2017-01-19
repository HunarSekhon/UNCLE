#pragma strict
private var guiShow : boolean = false;

var riddle : Texture;

function OnTriggerStay (Col : Collider){
	if(Col.tag == "Player")
	{
		guiShow = true;
	}
}
function OnTriggerExit (Col : Collider){
	if(Col.tag == "Player")
	{
		guiShow = false;
	}
}
function OnGUI(){
	if(guiShow == true){
		GUI.DrawTexture(Rect(Screen.width / 3, Screen.height / 3, 400, 200), riddle);
	}
}