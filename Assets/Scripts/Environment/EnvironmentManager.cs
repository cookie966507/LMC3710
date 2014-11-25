using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnvironmentManager : MonoBehaviour {
	public Transform snow;
	public Transform ice;
	public float snowAmount;

	public Transform player;

	void Start () {
	
	}
	
	void Update () {
		snow.GetComponent<EnvironmentElement> ().UpdateAmount (snowAmount);
		ice.GetComponent<EnvironmentElement> ().UpdateAmount (snowAmount/2);

		player.GetComponentInChildren<LookScript> ().setBobAmount (snowAmount);
	}

	public void SnowAmount(float amount){
		snowAmount = amount;
	}
}
