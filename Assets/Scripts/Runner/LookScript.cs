using UnityEngine;
using System.Collections;

public class LookScript : MonoBehaviour {

	public float lookSensitivity = 5.0f;

	private float amount = 1;

	float yRotation;
	float xRotation;

    float currentYRotation;
	float currentXRotation;

	float yRotationV = 0;
	float xRotationV = 0;

	public float bobSpeed = .7f;
	float bobStep;
	public float bobX = 1.0f;
	public float bobY = 1.0f;
//	Vector3 lastPosition;
	float eyeHeight = 1.0f;


	public float lookSmoothDamp = 0.1f;

	bool inverted = false;

	private string[] names;

	void Start () {
		names = Input.GetJoystickNames ();
//		Screen.lockCursor = true;
	}

	void Awake(){
//		lastPosition = transform.parent.position;
	}

	/*
	void Update () {
		//if(transform.parent.GetComponent<PlayerController>().isGrounded()){
		bobStep += bobSpeed;//Vector3.Distance(lastPosition, transform.parent.position)*bobSpeed;
		//}

		float localX = Mathf.Sin (bobStep)*bobX;
		float localY = (Mathf.Cos (bobStep*2.0f)*bobY*-1) + (transform.localScale.y*eyeHeight);// - (transform.localScale.y/2.0f);
		transform.localPosition = new Vector3(localX, localY, transform.localPosition.z);
	
//		lastPosition = transform.parent.position;

		yRotation += Input.GetAxis ("Mouse X")*lookSensitivity;

		if(inverted)
			xRotation += Input.GetAxis ("Mouse Y")*lookSensitivity;
		else
			xRotation -= Input.GetAxis("Mouse Y")*lookSensitivity;

		xRotation = Mathf.Clamp (xRotation, -90, 90);

		currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationV, lookSmoothDamp);
		currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationV, lookSmoothDamp);

		transform.rotation = Quaternion.Euler (currentXRotation, currentYRotation, 0);
	}
	*/

	void FixedUpdate(){
		//if(transform.parent.GetComponent<PlayerController>().isGrounded()){
		bobStep += bobSpeed;//Vector3.Distance(lastPosition, transform.parent.position)*bobSpeed;
		//}

		float localX;
		float localY;
		if(names.Length > 0){
			localX = Mathf.Sin (bobStep)*bobX * amount * Input.GetAxis("Vertical");
			localY = (Mathf.Cos (bobStep*2.0f)*bobY*amount*Input.GetAxis("Vertical")*-1) + (transform.localScale.y*eyeHeight);// - (transform.localScale.y/2.0f);
		}
		else{
			localX = Mathf.Sin (bobStep)*bobX * amount;
			localY = (Mathf.Cos (bobStep*2.0f)*bobY*amount*-1) + (transform.localScale.y*eyeHeight);// - (transform.localScale.y/2.0f);
		}
		transform.localPosition = new Vector3(localX, localY, transform.localPosition.z);
		
		//		lastPosition = transform.parent.position;
		
		yRotation += Input.GetAxis ("Mouse X")*lookSensitivity;
		
		if(inverted)
			xRotation += Input.GetAxis ("Mouse Y")*lookSensitivity;
		else
			xRotation -= Input.GetAxis("Mouse Y")*lookSensitivity;
		
		xRotation = Mathf.Clamp (xRotation, -90, 90);
		
		currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationV, lookSmoothDamp);
		currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationV, lookSmoothDamp);
		
		transform.rotation = Quaternion.Euler (currentXRotation, currentYRotation, 0);
	}

	public float getYRotation(){
		return currentYRotation;
	}
	public float getXRotation(){
		return currentXRotation;
	}

	public float getBobCounter(){
		return bobStep;
	}

	public void setBobAmount(float amount){
		this.amount = 1 -amount/2;
		this.amount = Mathf.Clamp (this.amount, .3f, 1);
	}
}
