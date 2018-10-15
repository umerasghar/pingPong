using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	void OnMouseDown(){
		
		GetComponent<Animator> ().enabled = false;	
	}
	void OnMouseUp(){
		
		Application.LoadLevel (1);
		//Screen.SetResolution (1366, 720, false);
	}

}
