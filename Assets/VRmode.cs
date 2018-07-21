using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class VRmode : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void selectVRmode(string Cardboard){
		
		if (Cardboard == "None") {
			PlayerPrefs.SetInt ("mode", 0);
			SceneManager.LoadScene ("Main Menu");
		} else {
			PlayerPrefs.SetInt ("mode", 1);
			SceneManager.LoadScene ("Main Menu");	
		}
	}

}
