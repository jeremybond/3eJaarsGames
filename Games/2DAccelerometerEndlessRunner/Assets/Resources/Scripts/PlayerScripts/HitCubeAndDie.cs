using UnityEngine;
using System.Collections;

public class HitCubeAndDie : MonoBehaviour {

	/*void OnTriggerEnter(Collider col){
		if(col.name == "Cube")
		{
			Debug.Log("nooooo");
			Application.LoadLevel(0);
		}
	}*/
	void OnCollisionEnter(Collision col)
	{
		if(collider.name == "Cube" || collider.name == "Cube(Clone)")
		{
			Debug.Log("nooooo");
			Application.LoadLevel(0);
			
		}
		
	}
}
