using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject obj;
	public float spawnTime = 1.5f;
	private float time = 0;
	public float maxDist = 7;
	
	// Update is called once per frame
	void Update () {
		time+=Time.deltaTime;
		if(time > spawnTime){
			time = 0;
			float dist = Random.Range(-maxDist, maxDist);
			if(dist < 0 && dist > -3){
				dist-=3;
			}
			else if(dist >= 0 && dist < 3){
				dist+=3;
			}
			Vector3 scale = new Vector3(dist, 0, 0);
			GameObject.Instantiate(obj, transform.position + scale, Quaternion.Euler(0, Random.Range(0, 360), Random.Range(-30, 30)));
		}
	}
}
