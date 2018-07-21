using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMode : MonoBehaviour {
	public float MyTime = 0;
	public bool lihatObjek = false;
	public Transform reCircle;
	int mode;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (lihatObjek) {
			MyTime += Time.deltaTime;
			reCircle.GetComponent<Image>().fillAmount = MyTime/2;
			if (MyTime > 2) {
				mode = PlayerPrefs.GetInt("Mode");
				backToMode (mode);
			}
		}
	}

	//	public void pindahScene(string scene){
	//		SceneManager.LoadScene(scene);
	//	}

	public void benarlihatObjek(){
		lihatObjek = true;
	}

	public void salahLihatObjek(){
		lihatObjek = false;
		MyTime = 0;
		reCircle.GetComponent<Image>().fillAmount = 0;
	}

	public void backToMode(int mode_){
		if (mode_==2) {
			SceneManager.LoadScene ("Roller VR");
		} else if (mode_==1) {
			SceneManager.LoadScene ("Roller Explorer");
		} else {
			SceneManager.LoadScene ("Explorer.Organ");
		}
	}
}

