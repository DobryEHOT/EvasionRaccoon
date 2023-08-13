using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSystemBlack : MonoBehaviour {


    public GameObject Ehot;

	void Start () {
		
	}
	

	void FixedUpdate () {
        transform.position = Vector3.Slerp(transform.position, Ehot.transform.position, 0.09f);

        transform.Rotate(new Vector3(0, 3, 0));
	}
}
