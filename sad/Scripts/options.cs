using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class options : MonoBehaviour {
    public AudioSource music;
    public Slider musicSlider;
	// Use this for initialization
	void Start () {
        musicSlider.value = music.volume;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
