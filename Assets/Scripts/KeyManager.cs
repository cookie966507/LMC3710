using UnityEngine;
using System.Collections;

public class KeyManager : MonoBehaviour {

	public bool pressed;
	
	public void Press(){
		pressed = true;
<<<<<<< HEAD
=======
		Invoke("Release", 5f);
>>>>>>> origin/master
	}
	
	public void Release(){
		pressed = false;
	}
<<<<<<< HEAD
	
	public void ReleaseTimer(float timer){
		Invoke("Release", timer);
	}
=======
>>>>>>> origin/master
}
