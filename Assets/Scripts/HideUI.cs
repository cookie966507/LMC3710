using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HideUI : MonoBehaviour {

	public GameObject[] UIs;

	delegate void Hide();
	Hide hide;

	void Start () {
		hide = hideAll;
	}

	public void Exec(){
		hide();
	}

	private void hideAll(){
		for(int i = 0; i < UIs.Length; i++){
			UIs[i].SetActive(false);
		}
		hide = revealAll;
	}

	private void revealAll(){
		for(int i = 0; i < UIs.Length; i++){
			UIs[i].SetActive(true);
		}
		hide = hideAll;
	}
}
