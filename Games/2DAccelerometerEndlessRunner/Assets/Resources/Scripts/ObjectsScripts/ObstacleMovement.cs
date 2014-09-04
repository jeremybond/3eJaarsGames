using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {

	void Update () {
		transform.position -= new Vector3(0, 0.05f, 0);
		if(transform.position.y <= -10)
		{
			Destroy(this.gameObject);
		}
	}
}
