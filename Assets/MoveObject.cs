using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour {
	public bool lihatObjek = false;
	public bool pindah = false;
	public bool setObject = true;
	public bool fokus1Objek = true;
	public MoveObject jalanLokasi;
	public int nomerLokasiID = 0;
	public float speed;
	public GameObject player;
	public Transform reCircle;
	public List<Transform> nomerObjek = new List<Transform> ();
//	Transform[] theArray;
	float MyTime;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(lihatObjek){
			MyTime += Time.deltaTime;
			reCircle.GetComponent<Image>().fillAmount = MyTime/2;
			if(MyTime > 2){
				pindah = true;
				lihatObjek = false;
				fokus1Objek = false;
			}
		}

		if(pindah){
			player.transform.position = Vector3.MoveTowards (player.transform.position, jalanLokasi.nomerObjek [nomerLokasiID].position, Time.deltaTime * speed);
			float distance = Vector3.Distance(player.transform.position, jalanLokasi.nomerObjek[nomerLokasiID].position);
			if(distance < 0.1){
				pindah = false;
				fokus1Objek = true;
			}
		}
	}

	public void setNomerLokasiID(int id){
		if (fokus1Objek) {
			nomerLokasiID = id;
		}
	}

//	void onDrawGrizmos(){
//		theArray = GetComponentsInChildren<Transform> ();
//		nomerObjek.Clear ();
//		foreach (Transform perObjek in theArray) {
//			if (perObjek != this.transform) {
//				nomerObjek.Add (perObjek);
//			}
//		}
//
//		for (int i = 0; i < nomerObjek.Count; i++) {
//			Vector3 position = nomerObjek [i].position;
//			if (i > 0) {
//				Vector3 previous = nomerObjek [i - 1].position;
//
//				Gizmos.DrawWireSphere (position, 2.7f);
//			}
//		}
//	}


	public void benarlihatObjek(){
		lihatObjek = true;
	}

	public void salahLokasiObjek(){
		lihatObjek = false;
		MyTime = 0;
		reCircle.GetComponent<Image> ().fillAmount = 0;
	}

//	public bool setPindah(){
//		if (pindah) {
//			return true;
//		} else {
//			return false;
//		}	
//	}
}
