using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {

	private Transform player;
	
	void Start () {
		player = GameObject.Find("Player").transform;
	}
	
	public void UpdateSpeed(){
		player.GetComponent<PlayerController>().maxRunSpeed += 20;
		player.GetComponent<PlayerController>().runAcceleration += 2000;
		Invoke("BackToNormal", 5-1);
	}
	public void BackToNormal(){
		player.GetComponent<PlayerController>().maxRunSpeed -= 20;
		player.GetComponent<PlayerController>().runAcceleration -= 2000;
	}
}
