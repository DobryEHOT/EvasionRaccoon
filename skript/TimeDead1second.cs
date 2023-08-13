using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDead1second : MonoBehaviour {

    public float Skoko = 1f;

	void Start () {
        Destroy(gameObject, Skoko);
	}
	

	void Update () {
		
	}
}
