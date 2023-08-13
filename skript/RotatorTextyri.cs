using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorTextyri : MonoBehaviour {

    public float speed = 2f;
    float TimDel;

	void Start () {
        TimDel = Time.deltaTime;
    }
	
	
	void FixedUpdate () {
        transform.Rotate(0, 0, speed * TimDel);


    }
}
