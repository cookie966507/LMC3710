using UnityEngine;
using System.Collections;

public class SnowBuildup : MonoBehaviour {
	public EnvironmentManager em;
	private static float time = 0;
	private float step = .0001f;
	private float maxSnow = 0.7f;

	void Start () {
		em = GameObject.Find ("Environment Manager").GetComponent<EnvironmentManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(em.snowAmount > 0){
			time+=(step*(em.snowAmount/2));
			time = Mathf.Clamp(time, 0, maxSnow);
			renderer.material.SetFloat("_Snow", time);
		}
		else{
			time-=(step);
			time = Mathf.Clamp(time, 0, maxSnow);
			renderer.material.SetFloat("_Snow", time);
		}
	}
}
