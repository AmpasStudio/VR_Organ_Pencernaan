using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class GyroCamera : MonoBehaviour {
	private Gyroscope gyro;
	private bool gyroSupported;
	private Quaternion rotfix;
	private bool modeVR = false;

	[SerializeField]
	private Transform worldObj;
	private float startY;

	// Use this for initialization
	IEnumerator LoadDevice(string Cardboard){
		VRSettings.LoadDeviceByName (Cardboard);
		yield return null;
		VRSettings.enabled = true;

	}

	void Awake(){
		if (PlayerPrefs.GetInt ("mode") == 0) {
			StartCoroutine (LoadDevice ("none"));
		} else {
			modeVR = true;
			StartCoroutine (LoadDevice ("cardboard"));
		}
	}
	void Start () {
		if (modeVR == false) {
			gyroSupported = SystemInfo.supportsGyroscope;

			GameObject camParent = new GameObject ("camParent");
			camParent.transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;
			camParent.transform.position = transform.position;
			transform.parent = camParent.transform;


			if (gyroSupported) {
				gyro = Input.gyro;
				gyro.enabled = true;

				transform.parent.rotation = Quaternion.Euler (90f, 180f, 0f);
				rotfix = new Quaternion (0, 0, 1, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (modeVR == false) {
			if (gyroSupported && startY == 0) {
				ResetGyroRotation ();
			}
			transform.localRotation = gyro.attitude * rotfix;
		}
	}

	void ResetGyroRotation(){
		startY = transform.eulerAngles.y;
		worldObj.rotation = Quaternion.Euler (0f, startY, 0f);
	}
}
