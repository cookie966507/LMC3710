using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public float timer = 91;

	private bool stop;
	
	void Update () {
		if(!stop){
			timer -= Time.deltaTime;

			int minutes = Mathf.FloorToInt(timer / 60F);
			int seconds = Mathf.FloorToInt(timer - minutes * 60);
		
			string time = string.Format("{0:00}:{1:00}", minutes, seconds);

			this.GetComponent<Text>().text = time;

			if(minutes <= 0 && seconds <= 0){
				this.GetComponent<Text>().color = Color.red;
				time = string.Format("{0:00}:{1:00}", 0, 0);
				this.GetComponent<Text>().text = time;
				stop = true;
			}
		}
	}
}
