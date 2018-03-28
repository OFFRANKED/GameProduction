using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	private int         Rand;
	public  AudioSource Jump;

	// Use this for initialization
	void Start () {
		Jump = GetComponent<AudioSource> ();
		InvokeRepeating ("EnemyMovementController", 2, 1);
	}

	void EnemyMovementController(){
		Rand = Random.Range (1, 100);

		if (Rand <= 25) {
			Jump.Play ();
			transform.position = transform.position + new Vector3 (0.65f, -0.95f, 0.0f);			
		}

		if (Rand >= 26 && Rand <= 50) {
			Jump.Play ();
			transform.position = transform.position + new Vector3 (-0.65f, 0.95f, 0.0f);			
		}


		if (Rand >= 51 && Rand <= 75) {
			Jump.Play ();
			transform.position = transform.position + new Vector3(-0.65f,-0.95f,0.0f);
        }


		if (Rand >= 76 && Rand <= 100) {
			Jump.Play ();
			transform.position = transform.position + new Vector3(0.65f,0.95f,0.0f);
		}
	}
}

