﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 6f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * speed);
	}
}
