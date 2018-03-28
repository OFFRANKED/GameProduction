using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {
	public  Text            scoreText;
	static  private int      Points;
    private AudioSource     Jump;

    private void Start ()
    {
        Jump = GetComponent<AudioSource>();
		Points = 0;
		scoreText.text = Points.ToString();
        GetComponent<AudioSource>();
	}
	
	private void Update ()
    {

		KeyInputs ();
	}

	private void KeyInputs(){
        //Movement
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Jump.Play();
            transform.position = transform.position + new Vector3(-0.65f, -0.95f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
		{
            Jump.Play();
            transform.position = transform.position + new Vector3(0.65f,-0.95f,0.0f);
		}
		if(Input.GetKeyDown(KeyCode.Keypad7))
		{
            Jump.Play();
            transform.position = transform.position + new Vector3(-0.65f,0.95f,0.0f);
		}

		if(Input.GetKeyDown(KeyCode.Keypad9))
		{
            Jump.Play();
            transform.position = transform.position + new Vector3(0.65f,0.95f,0.0f);
		}
	}

	public void AddPoints(int amount){
		Points = Points + amount;
		scoreText.text = Points.ToString();
	}
}
