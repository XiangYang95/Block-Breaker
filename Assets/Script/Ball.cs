﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float speed;
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			//lock the ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;

			//wait for a mouse press to lauch
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 2f) * speed;
			}
		}
	}
}
