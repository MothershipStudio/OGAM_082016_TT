using UnityEngine;
using System.Collections;

public class AnimatedMaterial : MonoBehaviour {

    public Material[] materials;

    private int currentIndex;
    private float initialTime;
    public float time;

	// Use this for initialization
	void Start () {
        this.currentIndex = 0;
        this.initialTime = Time.time;
        this.GetComponent<Renderer>().material.mainTextureScale = new Vector2(transform.lossyScale.x, transform.lossyScale.y);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.initialTime + this.time < Time.time)
        {
            this.initialTime = Time.time;

            this.currentIndex++;

            if (this.currentIndex == materials.Length) this.currentIndex = 0;

            this.GetComponent<Renderer>().material = materials[currentIndex];
            this.GetComponent<Renderer>().material.mainTextureScale = new Vector2(transform.lossyScale.x, transform.lossyScale.y);
        }
	}
}
