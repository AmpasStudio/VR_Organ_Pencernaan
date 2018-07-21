using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreOrganLoc : MonoBehaviour {
	private string nameBox;
	private string locationBox;
	public Transform player;
	// Use this for initialization
	void Start () {
		locationBox = PlayerPrefs.GetString ("Location_Explore");
		GameObject box = GameObject.Find (locationBox);
		player.position = box.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {
		setLocationExplore (other.name);
		Debug.Log (other.name+" : name save");
	}
	public void setLocationExplore(string name_){
		PlayerPrefs.SetString ("Location_Explore", name_);
	}
}
