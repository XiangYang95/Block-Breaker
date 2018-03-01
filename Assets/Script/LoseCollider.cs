using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	public LevelManager levelmanager;
	void OnCollisionEnter2D(Collision2D collider){
		levelmanager.LoadLevel ("Win");
	}

//	void OnTriggerEnter2D(Collider2D collider){
//		print ("Trigger");
//	}
}
