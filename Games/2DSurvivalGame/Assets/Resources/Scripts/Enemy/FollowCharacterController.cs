using UnityEngine;
using System.Collections;

public class FollowCharacterController : MonoBehaviour {
	GameObject character;
	void Start(){
		character = GameObject.Find("Character");
	}
	void Update () {
		SetRotation();
	}
	public void SetRotation(){
		Vector2 diff = getDifference(transform.position, character.transform.position);
		float angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
	}

	Vector2 getDifference(Vector3 startObj,Vector3 targetObj)
	{
		Vector2 diff = new Vector2(startObj.x - targetObj.x, startObj.y - targetObj.y);
		return diff;
	}
}
