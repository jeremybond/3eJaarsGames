using UnityEngine;
using System.Collections;

public class CharacterAnimations : MonoBehaviour {
	Animator anim;
	RaycastHit2D hit;
	GameObject mainCamera;

	void Awake () {
		anim = GetComponent<Animator>();
		mainCamera = GameObject.FindGameObjectWithTag("Camera");
	}
	void StartShooting(){
		anim.SetBool("ShootAnim", true);
	}
	void StopShooting(){
		anim.SetBool("ShootAnim", false);
	}
	void Update(){
		
		//Debug.DrawRay(transform.position, Vector3.up * 10, Color.green);
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			StartShooting();
		}else if(Input.GetKeyUp(KeyCode.Space)|| Input.GetMouseButtonUp(0)){
			StopShooting();
		}
	}
	void ShootRayCasts(){
		//hit = Physics2D.Raycast(Vector2.zero, Vector2.up);
		/*Ray shootingRay = new Ray(Vector2.zero, Vector2.up);
		float shootingRayLength = 15;
		if(Physics2D.Raycast(shootingRay, out hit)){
			if(hit.collider.tag == "Enemy"){
				Debug.Log("HIT AN ANEMAY");
			}
		}
		RaycastHit2D hitInfo1 = Physics2D.Raycast(player.transform.position, pointer.transform.position - player.transform.position);
		 */
		Vector3 mouseConvert = new Vector3(Input.mousePosition.x + transform.position.x, Input.mousePosition.y + transform.position.y, 10);
		//Vector3 pos = Camera.main.ScreenToWorldPoint(mouseConvert);
		Vector3 pos = mainCamera.camera.ScreenToWorldPoint(mouseConvert);
		Debug.Log(pos);
		// Vector3 pos = new Vector3(transform.position.x + Input.mousePosition.x, transform.position.y + Input.mousePosition.y, 0);
		RaycastHit2D hit = Physics2D.Raycast(transform.position, pos);
		Debug.DrawRay(transform.position, pos);
		if(hit.collider != null && hit.collider.tag == "Enemy")
		{
			//Debug.DrawRay(this.transform.position, plust);
			Debug.Log("DIE ZOMBIE DIE");
			//Debug.DrawRay(transform.position, Vector3.up * 10, Color.green);
		}
	
	}
}
