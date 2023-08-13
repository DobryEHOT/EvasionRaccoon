using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strela : MonoBehaviour {

    CharacterController controller;
    public float speed = 5;

	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	
	void FixedUpdate () {

        transform.position -= transform.right * Time.deltaTime * speed;
        
    }
}
