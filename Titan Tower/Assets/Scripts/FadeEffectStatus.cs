using UnityEngine;
using System.Collections;

public class FadeEffectStatus : MonoBehaviour {


    private float Speed = 0.5f;
    bool FadeIn;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
    void Update()
    {
        CanvasGroup Canvas = GetComponent<CanvasGroup>();
        if (FadeIn)
        {
            Canvas.alpha += Time.deltaTime * Speed;
            if (Canvas.alpha >= 1)
            {
                FadeIn = false;
            }
        }
        else
        {
            Canvas.alpha -= Time.deltaTime * Speed;
            if (Canvas.alpha <= 0)
            {
                FadeIn = true;
            }
        }
    }
	
}
