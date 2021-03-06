﻿using UnityEngine;
using System.Collections;

public class JumpHigher : MonoBehaviour {

	private Transform player;
	
	void Start () {
		player = GameObject.Find("Player").transform;
	}
	
	public void UpdateJump(){
		player.GetComponent<PlayerController>().jumpVelocity += 7;
		Invoke("BackToNormal", 7-1);
	}
	public void BackToNormal(){
		player.GetComponent<PlayerController>().jumpVelocity -= 7;
	}
}
