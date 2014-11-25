using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
//	Texture2D crosshair;
//	float crosshairX;
//	float crosshairY;

	void Start () {
		Screen.lockCursor = true;
//		crosshair = Resources.Load ("UI/game/crosshair") as Texture2D;
	}
	
	void Update () {
		if (Input.GetKeyDown("escape"))
			Screen.lockCursor = false;
		
		if(Input.GetMouseButtonDown(0))
			Screen.lockCursor = true;
	}

//	void OnGUI(){
//		crosshairX = (Screen.width / 2) - (crosshair.width / 2);
//		crosshairY = (Screen.height / 2) - (crosshair.height / 2);
//		GUI.DrawTexture(new Rect(crosshairX, crosshairY, crosshair.width, crosshair.height), crosshair);

		//For sub imaging
//		GUI.DrawTextureWithTexCoords(new Rect(0,0,32,32), theTexture, new Rect(0f,0f,0.125f,1f),true);
//	}
}
