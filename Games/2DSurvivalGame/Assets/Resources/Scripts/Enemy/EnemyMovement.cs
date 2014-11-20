using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	bool walk = true;

	void Update () {
		if(walk){
			transform.Translate(0, -0.05f, 0);
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			walk = false;
		}
	}
	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			walk = true;
		}
	} 
}
