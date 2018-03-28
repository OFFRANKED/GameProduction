using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour {
	public  Transform Stop_Point;
	bool    startElevator = false;

	
	// Update is called once per frame
	void Update () {
		if (startElevator == true) {
			float step = 1 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, Stop_Point.position, step);
		}
	}

	void OnCollisionEnter2D(Collision2D Collision){

		if (Collision.gameObject.CompareTag ("Player")){
			startElevator = true;
			Destroy (this.gameObject, 7);
		}
	}
}
