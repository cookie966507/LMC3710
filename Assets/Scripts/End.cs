using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {
<<<<<<< HEAD

	GameObject manager;
	GameObject manager2;

	void Start(){
		manager = GameObject.Find("GoodKeyManager");
		manager2 = GameObject.Find("BadKeyManager");
	}
=======
>>>>>>> origin/master
	
	void OnTriggerEnter(Collider col){
		PlayerController player = GameObject.Find("Player").GetComponent<PlayerController>();
		player.rigidbody.velocity = Vector3.zero;
		player.enabled = false;
		
		player.GetComponentInChildren<LookScript>().enabled = false;
		
		GameObject clock = GameObject.Find("Clock");
		clock.GetComponent<Clock>().stopCounter();
<<<<<<< HEAD
		manager.GetComponent<KeyManager>().Press();
		manager2.GetComponent<KeyManager>().Press();
=======
>>>>>>> origin/master
	}
	
	void OnTriggerStay(Collider col){
		PlayerController player = GameObject.Find("Player").GetComponent<PlayerController>();
		player.rigidbody.velocity = Vector3.zero;
		player.enabled = false;
		
		player.GetComponentInChildren<LookScript>().enabled = false;
		
		GameObject clock = GameObject.Find("Clock");
		clock.GetComponent<Clock>().stopCounter();
<<<<<<< HEAD
		manager.GetComponent<KeyManager>().Press();
		manager2.GetComponent<KeyManager>().Press();
=======
>>>>>>> origin/master
	}
}
