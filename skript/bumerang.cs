using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumerang : MonoBehaviour {

   float x = 14;
   float y = 0;
   public float vichet = 0.007f;
   public float dobavka = 0.005f;

    public GameObject bum;
    float z;

	void Start () {
		
	}
	
	
	void FixedUpdate () {

        transform.position -= transform.right * Time.deltaTime * x;
        x -= vichet + y;
        y += dobavka;

        bum.transform.rotation = Quaternion.AngleAxis(z, Vector3.up);
        z += 3f;
    }
}
