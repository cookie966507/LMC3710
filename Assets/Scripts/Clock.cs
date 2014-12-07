using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clock : MonoBehaviour {

	public float gameTime = 0;
	private bool stop = false;
	
	void Start () {
	
	}
	
	void Update () {
		if(!stop){
			gameTime += Time.deltaTime;
			
			int minutes = Mathf.FloorToInt(gameTime / 60F);
			int seconds = Mathf.FloorToInt(gameTime - minutes * 60);
			
			string time = string.Format("{0:00}:{1:00}", minutes, seconds);
			
			this.GetComponent<Text>().text = time;
		}
		else{
			this.GetComponent<Text>().color = Color.red;
		}
	}
	
	public void stopCounter(){
		stop = true;
	}
}
