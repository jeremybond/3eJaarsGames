using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	void Update () {
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
			transform.position += new Vector3(-0.1f, 0, 0);
		}else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
			transform.position += new Vector3(0, 0.1f, 0);
		}else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
			transform.position += new Vector3(0, -0.1f, 0);
		}else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
			transform.position += new Vector3(0.1f, 0, 0);
		}
	}
}
