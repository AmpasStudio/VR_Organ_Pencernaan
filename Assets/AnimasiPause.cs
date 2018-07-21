using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class AnimasiPause : MonoBehaviour {

	Animator animator;
	public AudioSource sumberSuara;

//	private Coroutine fillBarRoutine;


	void Start () {
		animator = GetComponent<Animator> ();

	}    

	void Update(){

	}

	public void pauseAnimasi(){
		animator.speed = 0;
		sumberSuara.Stop ();
//		fillBarRoutine = StartCoroutine (FillBar ());
	}

	public void jalanAnimasi(){
		animator.speed = 1;
		sumberSuara.Play ();
//		if(fillBarRoutine!=null){
//			StopCoroutine (fillBarRoutine);
//		}
	}

//	private IEnumerator FillBar(){
//		yield return null;
//
//	}
}