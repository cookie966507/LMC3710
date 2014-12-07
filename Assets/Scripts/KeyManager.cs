using UnityEngine;
using System.Collections;

public class KeyManager : MonoBehaviour {

	public bool pressed;
	
	public void Press(){
		pressed = true;
	}
	
	public void Release(){
		pressed = false;
	}
	
	public void ReleaseTimer(float timer){
		Invoke("Release", timer);
	}
}
