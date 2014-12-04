using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class KeyButton : MonoBehaviour {
	
	public string kc;
	private KeyCode key;
	
	float timer = 5;
	
	public KeyManager manager;
	
	void Awake(){
		key = (KeyCode)System.Enum.Parse(typeof(KeyCode), kc) ;
	}
	
	void Update()
	{
		var pointer = new PointerEventData(EventSystem.current);
		
		if (Input.GetKeyDown(key) && !manager.pressed)
		{
			manager.Press();
			ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.pointerEnterHandler);
			ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.submitHandler);
			Invoke("ReleaseKey", timer);
		}
		//if(Input.GetKeyUp(key)){
		//	ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.pointerExitHandler);
		//}
	}
	
	private void ReleaseKey(){
		var pointer = new PointerEventData(EventSystem.current);
		
		ExecuteEvents.Execute(gameObject, pointer, ExecuteEvents.pointerExitHandler);
	}
}
