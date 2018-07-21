using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour {
	public float MyTime = 0;
	public bool lihatObjek = false;
	[SerializeField] private string namaScene;
	public Transform reCircle;

//	void Awake ()
//	{
//		Debug.Log("Awake called.");
//	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (lihatObjek) {
			MyTime += Time.deltaTime;
			reCircle.GetComponent<Image>().fillAmount = MyTime/2;
			if (MyTime > 2) {
				SceneManager.LoadScene (namaScene);
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

	public void setModeRoller(int kondisi){
		if (kondisi==2) {
			PlayerPrefs.SetInt ("Mode", 2);
		} else if (kondisi==1) {
			PlayerPrefs.SetInt ("Mode", 1);
		} else {
			PlayerPrefs.SetInt ("Mode", 0);
		}
	}




}
