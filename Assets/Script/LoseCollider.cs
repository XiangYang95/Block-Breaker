using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	private LevelManager levelmanager;

	void Start(){
		levelmanager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D(Collision2D collider){
		levelmanager.LoadLevel ("Lose");
	}

//	void OnTriggerEnter2D(Collider2D collider){
//		print ("Trigger");
//	}
}
