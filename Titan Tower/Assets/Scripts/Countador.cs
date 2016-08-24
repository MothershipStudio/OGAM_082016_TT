using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countador : MonoBehaviour {

	public int seconds;
	Text text;

	// Use this for initialization
	void Start () {
		StartCoroutine("CountTime");
		text = gameObject.GetComponent<Text>();
	}

	void Update(){
		text.text = "" + seconds;
	}
	
	IEnumerator CountTime(){
		while(seconds>0){
			yield return new WaitForSeconds(1);
			seconds--;
		}
		OnTimeOver();
	}

	void OnTimeOver(){
		
	}
}
