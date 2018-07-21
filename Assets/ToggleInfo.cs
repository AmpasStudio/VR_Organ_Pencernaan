using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleInfo : MonoBehaviour {

	private bool tombolInfo = false;
	public GameObject infoOrgan;
	public AudioSource sumberSuara;
	public AudioClip setSuara;
	public float MyTime = 0;
	public bool lihatObjek = false;
	public Transform reCircle;

	// Use this for initialization
	void Start () {
//		sumberSuara.clip = setSuara;
	}

	// Update is called once per frame
	void Update () {
		if (lihatObjek) {
			MyTime += Time.deltaTime;
			reCircle.GetComponent<Image>().fillAmount = MyTime/2;
			if (MyTime > 2) {
				replayInfo ();
			}
		}
	}


	public void replayInfo(){
		sumberSuara.clip = setSuara;
		if (tombolInfo) {

			infoOrgan.SetActive (false);
			sumberSuara.Stop ();
			tombolInfo = false;
			salahLihatObjek ();


		} else {

			infoOrgan.SetActive (true);
			sumberSuara.Play ();
			tombolInfo = true;
			salahLihatObjek ();
		}

	}

	public void benarlihatObjek(){
		lihatObjek = true;
	}

	public void salahLihatObjek(){
		lihatObjek = false;
		MyTime = 0;
		reCircle.GetComponent<Image> ().fillAmount = 0;
	}
}
