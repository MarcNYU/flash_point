using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_controller : MonoBehaviour {
	public light_object obj;
	public bool rOn;
	public bool lOn;
	public Light FL;
	// Use this for initialization
	void Start () {
		lOn = false;
		rOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.mouse0)) {lOn = !lOn;} 
		else if (Input.GetKey (KeyCode.mouse1)) {rOn = !rOn;}


		if (!(rOn && lOn)) {
			FL.color.b.Equals(0f);
			FL.color.r.Equals(0f);
		}
		else if (rOn && lOn) {
			FL.color.b.Equals(2f);
			FL.color.r.Equals(2f);
		}
		else if(rOn){
			//FL.color.g = 0f;
			FL.color.r.Equals(2f);
			FL.color.b.Equals(0f);
		}
		else if (lOn) {
			//FL.color.g = 0f;
			FL.color.r.Equals(0f);
			FL.color.b.Equals(2f);
		}


	}
}
