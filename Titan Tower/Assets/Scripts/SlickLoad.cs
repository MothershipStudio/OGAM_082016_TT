
using UnityEngine;

public class SlickLoad : MonoBehaviour {
	
	private CanvasGroup Bibou;
	public float Speed = 1f; 
	private float Count = 0f;
	public float Wait = 0f;
	private float Count2 = 0f;


	void Start () {
		Bibou = this.GetComponent<CanvasGroup> ();
	}

	void Update () {
		if (Wait != 0){
			Bibou.alpha = 0;
			Count2 += Time.deltaTime*Wait;
		}
		if (Mathf.Abs(Count2) >= 1) {Wait = 0;}

		if (Speed != 0 && Wait == 0){
		Bibou.alpha = Mathf.Min (1,Count);
		Count += Time.deltaTime*Speed;
		}
		if (Mathf.Abs(Count) >= 1) {Bibou.alpha = 1; Speed = 0;}
	}

	public void SetFadeIn(float Time){
		Speed = Time;
		Count = 0;
	} 

	public void SetFadeOut(float Time){
		Speed = -1* Time;
		Count = 1f;
	}
}