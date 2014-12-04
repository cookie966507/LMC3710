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
		Invoke("BackToNormal", 5);
	}
	public void BackToNormal(){
		player.GetComponent<PlayerController>().wind -= .7f*dir;
		dir *= (-1);
	}
}
