using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float speed = 5;
	private float amount = 1;

	private string[] names;

	private EnvironmentManager em;

	void Start () {
		names = Input.GetJoystickNames ();
		em = GameObject.Find ("Environment Manager").GetComponent<EnvironmentManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(names.Length > 0){
			transform.position += new Vector3(0, 0, -speed*Input.GetAxis("Vertical")*amount*Time.deltaTime);
		}
		else{
			transform.position += new Vector3 (0, 0, -speed * amount * Time.deltaTime);
		}
		amount = 1 - em.snowAmount/2;
		amount = Mathf.Clamp (amount, .3f, 1);
	}
}
