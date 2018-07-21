using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCoasterAnim : MonoBehaviour {
	private int number;
	public int totalLocation;
	public Animator animasi;
	// Use this for initialization
	void Start () {
		number = PlayerPrefs.GetInt ("Number_coaster");
		animasi.Play (number.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		if (animasi.GetCurrentAnimatorStateInfo(0).IsName(number.ToString())) {
			setRollerLocation (number);
			if (number > totalLocation) {
				number = 0;
			} else {
				number++;
			}
			print (number.ToString());
		}

	}

	public void setRollerLocation(int number_){
		PlayerPrefs.SetInt ("Number_coaster", number_);
	}
}
