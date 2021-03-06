using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Animasi : MonoBehaviour {
	private bool tombolAnimasi = false;
	public Animator animasi;
	public string tombolPlay;
	public string tombolRewind;
//	public AudioSource playSuara;
//	public AudioClip setSuara;
	public float MyTime = 0;
	public bool lihatObjek = false;
	public Transform reCircle;

//	public Animation anim;

	// Use this for initialization
	void Start () {
//		playSuara.clip = setSuara;

//		Transform mixTransform = transform.Find ("Lambung_Makanan/Lambung/Lambung_Makanan_Pecah");
//
//		anim ["Lambung"].AddMixingTransform (mixTransform);
	}
	
	// Update is called once per frame
	void Update () {
		if (lihatObjek) {
			MyTime += Time.deltaTime;
			reCircle.GetComponent<Image>().fillAmount = MyTime/2;
			if (MyTime > 2) {
				replayAnimasi ();
			}
		}
	}

//	public void pindahScene(string scene){
//		SceneManager.LoadScene (scene);
//	}

	public void playAnimation(string play){
		animasi.Play (play);
//		animasi.
	}

	public void rewindAnimation(string rewind){
		animasi.Play (rewind);
	}

	public void replayAnimasi(){
		
		if (tombolAnimasi) {
			rewindAnimation (tombolRewind);
//			playSuara.Stop ();
			tombolAnimasi = false;
			salahLihatObjek ();

		} else {
			playAnimation (tombolPlay);
//			playSuara.Play ();
			tombolAnimasi = true;
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
