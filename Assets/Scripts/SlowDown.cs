using UnityEngine;
using System.Collections;

public class SlowDown : MonoBehaviour {

	private Transform player;
	
	void Start () {
		player = GameObject.Find("Player").transform;
	}
	
	public void UpdateSpeed(){
		player.GetComponent<PlayerController>().maxRunSpeed -= 20;
		player.GetComponent<PlayerController>().runAcceleration -= 1000;
		Invoke("BackToNormal", 5f);
	}
	public void BackToNormal(){
		player.GetComponent<PlayerController>().maxRunSpeed += 20;
		player.GetComponent<PlayerController>().runAcceleration += 1000;
	}
}
