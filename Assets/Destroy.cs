using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float time;
	
	void Start () {
		Destroy(gameObject, time);
	}
}
