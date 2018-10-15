using UnityEngine;
using System.Collections;

public class enemymov : MonoBehaviour {

	public float speed = 8;
	Vector3 target;
	Vector3 pos;
	GameObject ball;

	// Update is called once per frame
	void Update () {
		ball = GameObject.FindGameObjectWithTag ("BALL");
		if (ball != null) {
			target = Vector3.Lerp (gameObject.transform.position, ball.transform.position, Time.deltaTime * speed);
			pos = new Vector3 (69.5862F, Mathf.Clamp (target.y, 30, 36), 0.5313938F);
			Debug.Log (target.y);
			gameObject.transform.position = new Vector3 (69.5862F, pos.y,0.5313938F);
		    
		}
	}
}
