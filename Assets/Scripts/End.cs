using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {
	
	void OnTriggerEnter(Collider col){
		PlayerController player = GameObject.Find("Player").GetComponent<PlayerController>();
		player.rigidbody.velocity = Vector3.zero;
		player.enabled = false;
		
		player.GetComponentInChildren<LookScript>().enabled = false;
		
		GameObject clock = GameObject.Find("Clock");
		clock.GetComponent<Clock>().stopCounter();
	}
	
	void OnTriggerStay(Collider col){
		PlayerController player = GameObject.Find("Player").GetComponent<PlayerController>();
		player.rigidbody.velocity = Vector3.zero;
		player.enabled = false;
		
		player.GetComponentInChildren<LookScript>().enabled = false;
		
		GameObject clock = GameObject.Find("Clock");
		clock.GetComponent<Clock>().stopCounter();
	}
}
