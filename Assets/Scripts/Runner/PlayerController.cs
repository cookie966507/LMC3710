using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float runAcceleration = 5000f;
	public float deceleration = .15f;
	public float maxRunSpeed = 22.0f;
	public float jumpVelocity = 10.0f;
	public float maxSlope = 45.0f;
	public float airControl = 0.3f;
	//public float maxSprint = 500.0f;
	//public float sprintTime = 500.0f;
	//public float sprintStep = 1.0f;
	//bool canSprint = true;
	//bool sprinting = false;
	//public float waitToRecharge = 50.0f;
	//float recharge = 0;
	
	float slowX;
	float slowZ;
	
	public float wind = 0;

	bool grounded = false;

	public GameObject playerCamera;

	Vector2 horizontalMovement;
	
	void Update () {
		move ();

		//infoHandler();
	}

	void move(){
		//maxRunSpeed = 30.0f;
		//runAcceleration = 5000;
		
		horizontalMovement = new Vector2(rigidbody.velocity.x, rigidbody.velocity.z);

		if(horizontalMovement.magnitude > maxRunSpeed){
			horizontalMovement.Normalize ();
			horizontalMovement *= maxRunSpeed;
		}
		
		rigidbody.velocity = new Vector3(horizontalMovement.x + wind, rigidbody.velocity.y, horizontalMovement.y);
		
		//transform.rotation = Quaternion.Euler (0, playerCamera.GetComponent<LookScript>().getYRotation(), 0);


		if(grounded){
			rigidbody.AddRelativeForce (Input.GetAxis("Horizontal")*runAcceleration*Time.deltaTime, 0, Input.GetAxis("Vertical")*runAcceleration*Time.deltaTime);
			rigidbody.velocity = new Vector3(Mathf.SmoothDamp (rigidbody.velocity.x, 0, ref slowX, deceleration), rigidbody.velocity.y, Mathf.SmoothDamp (rigidbody.velocity.z, 0, ref slowZ, deceleration));
		}
		else{
			rigidbody.AddRelativeForce (Input.GetAxis("Horizontal")*runAcceleration*airControl*Time.deltaTime, 0, Input.GetAxis("Vertical")*runAcceleration*airControl*Time.deltaTime);
		}
		
		if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && grounded){
			rigidbody.velocity = new Vector3(Mathf.SmoothDamp (rigidbody.velocity.x, 0, ref slowX, deceleration), rigidbody.velocity.y, Mathf.SmoothDamp (rigidbody.velocity.z, 0, ref slowZ, deceleration));
		}
		
		if(Input.GetButtonDown("Jump") && grounded){
			rigidbody.AddForce (0, jumpVelocity, 0, ForceMode.Impulse);
			grounded = false;
		}
	}

	void OnCollisionStay(Collision col){
		foreach(ContactPoint contact in col.contacts){
			if(Vector3.Angle(contact.normal, Vector3.up) < maxSlope)
				grounded = true;
		}
	}

	void OnCollisionExit(){
		grounded = false;
	}

	public bool isGrounded(){
		return grounded;
	}
}
