using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimatedBackground : MonoBehaviour {

    public float time = 0.2f;

    public Sprite[] images;

    private float initialTime;
    private int currentIndex;
    private Image canvas;

	// Use this for initialization
	void Start () {
        this.canvas = gameObject.GetComponent<Image>();
        this.currentIndex = 0;
        this.initialTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.initialTime + this.time < Time.time)
        {
            this.initialTime = Time.time;

            this.currentIndex++;

            if (this.currentIndex == images.Length) this.currentIndex = 0;

            this.canvas.sprite = images[currentIndex];
        }
	}
}
