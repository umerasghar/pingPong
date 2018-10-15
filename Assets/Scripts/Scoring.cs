using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour {

	public GameObject Score;
	public GameObject ballprefab;
	public Transform paddle;
	GameObject ball;
	int score=0;

	void Update (){
		ball = GameObject.FindGameObjectWithTag ("BALL");
		Score.GetComponent<Text> ().text = "" + score;
	
	}
	void OnTriggerEnter(Collider col){
		if (col.tag== "BALL") {
			score += 1;

			Destroy (ball);
			(Instantiate(ballprefab,new Vector3(paddle.transform.position.x+1,paddle.transform.position.y,paddle.transform.position.z),Quaternion.identity)as GameObject)
				.transform.parent=paddle;

		}
			
	}

}
 