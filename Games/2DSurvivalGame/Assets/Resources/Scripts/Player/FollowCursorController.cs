using UnityEngine;
using System.Collections;

public class FollowCursorController : MonoBehaviour {
	GameObject mainCamera;
	void Start(){
		mainCamera = GameObject.FindGameObjectWithTag("Camera");
	}


	
	void Update () {
		Vector3 pos = mainCamera.camera.WorldToScreenPoint(transform.position);
		Vector2 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); 
	}
}
