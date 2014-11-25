using UnityEngine;
using System.Collections;

public class EnvironmentElement : MonoBehaviour {
	public ParticleSystem particles;
	public float amount;
	public Vector4 dirs;
	public float initAmount;

	void Start(){
		initAmount = particles.emissionRate;
		particles.emissionRate = amount;
	}

	public void UpdateDirs(Vector4 dirs){
		this.dirs = dirs;
	}

	public void UpdateAmount(float amount){
		this.amount = amount;
		particles.emissionRate = initAmount * amount;
	}
}
