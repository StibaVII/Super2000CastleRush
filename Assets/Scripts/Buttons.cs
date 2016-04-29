using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    public GameObject closeOptionsPanel;
    public GameObject closeCreditsPanel;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Play(){
		Debug.Log ("Game Start");
		Application.LoadLevel(1);
    }

    public void Options()
    {
        closeOptionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        closeOptionsPanel.SetActive(false);
    }

    public void Credits()
    {
        closeCreditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        closeCreditsPanel.SetActive(false);
    }
}
