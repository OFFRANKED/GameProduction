using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour {
    public  Sprite              ToChange;
    private SpriteRenderer      OldSprite;
	public  PlayerController    Script;
    private void Start()
    {
        OldSprite = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D Collision){

		if (Collision.gameObject.CompareTag("Player"))
        {
            if(OldSprite.sprite != ToChange)
            {
                OldSprite.sprite = ToChange;
                Script.AddPoints(100);
            }			
		}
	}
}
