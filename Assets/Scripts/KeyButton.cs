using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class KeyButton : MonoBehaviour {
	
	public string kc;
	private KeyCode key;
	
	public float timer = 5;
	
	public KeyManager manager;
	public Image im;
	private float step;
	private float counter;
	
	void Awake(){
		key = (KeyCode)System.Enum.Parse(typeof(KeyCode), kc) ;
		step = im.transform.localScale.x/timer;
	}
	
	void Update()
	{
		var pointer = new PointerEventData(EventSystem.current);
		
		if (Input.GetKeyDown(key) && !manager.pressed)
		{
			manager.Press();
			ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.pointerEnterHandler);
			ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.submitHandler);
			Invoke("ReleaseKey", timer-1);
			manager.ReleaseTimer(timer-1);
			im.gameObject.SetActive(true);
			InvokeRepeating("ScaleDown", 0, step);
		}
		//if(Input.GetKeyUp(key)){
		//	ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.pointerExitHandler);
		//}
	}
	
	private void ReleaseKey(){
		var pointer = new PointerEventData(EventSystem.current);
		
		ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.pointerExitHandler);
		
		CancelInvoke("ScaleDown");
		
		im.transform.localScale = new Vector3(2, 0.2f, 1);
		im.gameObject.SetActive(false);
	}
	
	private void ScaleDown(){
		float x = Mathf.Lerp(im.transform.localScale.x, im.transform.localScale.x - step, step);
		im.transform.localScale = new Vector3(x, im.transform.localScale.y, im.transform.localScale.z);
	}
}
