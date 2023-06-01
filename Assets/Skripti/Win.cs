using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
	public GameObject backgroundAward;
	public  static int masinas=0;
	public void again() {
		backgroundAward.SetActive (false);
		masinas = 0;

	}

	// Use this for initialization
	void Start () {
		masinas = 0;
		backgroundAward.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (masinas == 11) {
			backgroundAward.SetActive (true);
		}
	}
}
