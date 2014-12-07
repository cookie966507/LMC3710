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
<<<<<<< HEAD
		Invoke("BackToNormal", 5-1);
=======
		Invoke("BackToNormal", 5f);
>>>>>>> origin/master
	}
	public void BackToNormal(){
		player.GetComponent<PlayerController>().maxRunSpeed -= 20;
		player.GetComponent<PlayerController>().runAcceleration -= 2000;
	}
}
