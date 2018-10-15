using UnityEngine;
using System.Collections;

public class movment : MonoBehaviour {

	public float speed=1F;

	public Vector3 pos;


	
	// Update is called once per frame
	void Update () {
		float mov=gameObject.transform.position.y+(Input.GetAxis("Vertical")*speed);
		pos = new Vector3 (54.02879F, Mathf.Clamp (mov, 30.75f, 36f),  0.5313938F);
		gameObject.transform.localPosition = pos;
	}
}
