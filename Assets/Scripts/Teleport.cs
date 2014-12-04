using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	private Transform player;
	
	void Start () {
		player = GameObject.Find("Player").transform;
	}
	
	public void TeleportPlayer(){
		player.position += new Vector3(0, 5, 20);
	}
}
