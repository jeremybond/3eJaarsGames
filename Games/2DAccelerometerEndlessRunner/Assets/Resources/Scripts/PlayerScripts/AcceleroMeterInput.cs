using UnityEngine;
using System.Collections;

public class AcceleroMeterInput : MonoBehaviour {

	Vector3 movementVector = new Vector3(1, 0, 0);
	void Start () {
		StartCoroutine(AcceleratingCheck());

	}

	IEnumerator AcceleratingCheck()
	{
		if(Input.acceleration.x >= -1f && Input.acceleration.x <= 1f)
		{
			//Debug.Log(Input.acceleration.x);
			if(Input.acceleration.x <= -0.6f && transform.position.x >= -2) 
			{
				transform.position -= movementVector;
				yield return new WaitForSeconds(0.1f);
			} 
			if(Input.acceleration.x >= 0.6f && transform.position.x <= 2) 
			{
				transform.position += movementVector;
				yield return new WaitForSeconds(0.1f);
			}
		}
		yield return null;
		StartCoroutine(AcceleratingCheck());
	}
}
