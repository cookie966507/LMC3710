using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour {

	private Transform player;
	private int dir = 1;
	
	void Start () {
		player = GameObject.Find("Player").transform;
	}
	
	public void UpdateWind(){
		player.GetComponent<PlayerController>().wind += .7f*dir;
<<<<<<< HEAD
		Invoke("BackToNormal", 3-1);
=======
		Invoke("BackToNormal", 5);
>>>>>>> origin/master
	}
	public void BackToNormal(){
		player.GetComponent<PlayerController>().wind -= .7f*dir;
		dir *= (-1);
	}
}
