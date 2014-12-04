using UnityEngine;
using System.Collections;

public class KeyManager : MonoBehaviour {

	public bool pressed;
	
	public void Press(){
		pressed = true;
		Invoke("Release", 5f);
	}
	
	public void Release(){
		pressed = false;
	}
}
