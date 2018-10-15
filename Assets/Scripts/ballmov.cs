using UnityEngine;
using System.Collections;

public class ballmov : MonoBehaviour {

	public float speed = 1000;
	Rigidbody r;
	bool play;
	int rand;
	void Awake() {
		r = gameObject.GetComponent<Rigidbody> ();
		rand = Random.Range (1, 3);
	}
	

	void Update () {
		if(Input.GetMouseButton(0)==true&&play==false){
			transform.parent = null;
			play = true;
			r.isKinematic = false;
			if (rand == 1) {
				r.AddForce(new Vector3(speed,speed,0));
			}
					if(rand==2){
				r.AddForce (new Vector3 (-speed, -speed, 0));
					}
		}
						
	}
}
