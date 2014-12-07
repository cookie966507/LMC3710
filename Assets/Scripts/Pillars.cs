using UnityEngine;
using System.Collections;

public class Pillars : MonoBehaviour {

	private Transform player;
	private GameObject pillars;
	
	void Start () {
		player = GameObject.Find("Player").transform;
		pillars = (GameObject)Resources.Load("Prefabs/pillars");
	}
	
	public void UpdatePillars(){
		Instantiate(pillars, player.position + new Vector3(0, 0, 10) - new Vector3(0, player.position.y, 0), Quaternion.identity);
	}
}
