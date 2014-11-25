using UnityEngine;
using System.Collections;

public class DestroyObjects : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
